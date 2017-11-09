using UnityEngine;
using System.Collections;

public class Lookout : MonoBehaviour
{
	public Transform target;

	void Start ()
	{
	
	}
	
	void Update ()
	{	
		//DetectTarget()がtrueなら赤色falseなら緑色
		Debug.DrawLine (transform.position, target.position, DetectTarget() ? Color.red : Color.green);
	
	}

	bool DetectTarget ()
	{
		Vector3 direction = target.position - transform.position;
		RaycastHit hit;

		if (Vector3.Angle (transform.forward, direction) < 30f) {
			if (Physics.Raycast (transform.position, direction, out hit)) {
				if (hit.transform == target) {
					return true;
				}
			}
		}

		return false;
	}
}
