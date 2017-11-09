using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour
{
	public float rotationSpeed = 360f;

	Vector3 prevPosition;

	void Start ()
	{
		prevPosition = transform.position;
	}
	
	void Update ()
	{

		//移動している方向に回転する
		Vector3 direction = transform.position - prevPosition;

		if (direction.sqrMagnitude > 0) {
			Vector3 forward = Vector3.Slerp (
				transform.forward, 
				new Vector3(direction.x, 0, direction.z),  
				rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction)
			);
			
			transform.LookAt (transform.position + forward);
		}

		prevPosition = transform.position;
	}
}
