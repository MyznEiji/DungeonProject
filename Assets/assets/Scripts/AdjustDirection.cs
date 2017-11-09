using UnityEngine;
using System.Collections;

public class AdjustDirection : MonoBehaviour
{
	public float maxDistance = 3f;
	public float maxAngle = 45f;

	void Start ()
	{
	}

	void Update ()
	{
		Debug.DrawRay(transform.position, transform.forward * maxDistance, Color.green);

		if (Input.GetButtonDown("Jump")) {

			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit = new RaycastHit ();


			if (Physics.Raycast (ray, out hit, maxDistance)) {
				Vector3 target = hit.collider.transform.position;
				target.y = transform.position.y;
				
				if (Vector3.Angle (transform.forward, target - transform.position) < maxAngle) {
					Debug.DrawRay(transform.position, transform.forward * maxDistance, Color.red, 1f);
					transform.LookAt (target);
				}
			}
		}
	}
}