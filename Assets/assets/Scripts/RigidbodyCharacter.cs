using UnityEngine;
using System.Collections;

public class RigidbodyCharacter : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float footDistance;

	public Vector3 velocity;
	public bool isGround;

	Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		footDistance = GetComponent<Collider> ().bounds.min.y;
	}	
	
	void Update ()
	{
		Vector3 direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")) * moveSpeed;

		velocity.x = direction.x;
		velocity.z = direction.z;

		if (Input.GetKeyDown (KeyCode.Space)) {
			velocity.y = 5f;
			isGround = false;
		}
	}

	void FixedUpdate ()
	{
		rb.MovePosition (transform.position + velocity * Time.fixedDeltaTime);

		if (Physics.Raycast(transform.position + GetComponent<Collider> ().bounds.min, Vector3.down, 0.1f)) {
			velocity.y = 0;
			isGround = true;
		} else {
			velocity.y += -9.81f * Time.fixedDeltaTime;
			isGround = false;
		}		
	}
}
