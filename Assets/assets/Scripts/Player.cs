using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
	public float moveSpeed = 5f;
	public bool inAction;

	Animator anim;
	CharacterController controller;
	NavMeshAgent agent;

	Vector3 velocity;

	void Start ()
	{
		anim = GetComponent<Animator> ();
		controller = GetComponent<CharacterController> ();
		agent = GetComponent<NavMeshAgent> ();
	}
	
	void Update ()
	{
		Vector3 direction = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		if (controller && !inAction) {
			controller.SimpleMove(direction * moveSpeed);
		}

		if (anim) {
			if (controller) {
				anim.SetFloat("Speed", controller.velocity.magnitude);
			}

			// if (agent) {
			// 	anim.SetFloat("Speed", agent.velocity.magnitude);
			// }			
		}
	}

	void PlaySfx(AudioClip clip) {

	}
}
