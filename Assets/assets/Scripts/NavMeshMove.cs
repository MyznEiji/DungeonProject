using UnityEngine;
using System.Collections;
using UnityEngine.AI;


public class NavMeshMove : MonoBehaviour
{
	public float moveSpeed = 5f;

	NavMeshAgent agent;
	Animator anim;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}
	
	void Update ()
	{
		var direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		agent.Move (direction * moveSpeed * Time.deltaTime);

		if (anim) {
			anim.SetFloat("Speed", (direction * moveSpeed).magnitude);
		}
	}
}
