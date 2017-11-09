using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour
{
	public float maxDistance = 2f;
	public float maxAngle = 30f;

	void Start () {}
	
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			TurnCharactor ();
		}
	}

	public void TurnCharactor ()
	{
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit = new RaycastHit ();

		if (Physics.Raycast (ray, out hit, maxDistance)) {
			Vector3 target = hit.collider.transform.position;
			target.y = transform.position.y;

			if (Vector3.Angle (transform.forward, target - transform.position) < maxAngle) {
				transform.LookAt (target);
			}
		}
	}
}
