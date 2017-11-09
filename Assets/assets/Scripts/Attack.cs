using UnityEngine;
using System.Collections;

public class Attack : StateMachineBehaviour
{
	public string targetTagName;
	public float start, end;
	public float size = 0.5f;

	GameObject target;
	SphereCollider hitCollision;

	override public void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		if (!hitCollision) {
			foreach (var obj in GameObject.FindGameObjectsWithTag(targetTagName)) {
				if (obj.transform.IsChildOf (animator.transform)) {
					obj.AddComponent<Rigidbody>();
					
					hitCollision = obj.AddComponent<SphereCollider>();
					hitCollision.radius = size;
					hitCollision.enabled = false;
					
					break;
				}
			}
		}
	}

	override public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		float currentTime = stateInfo.length * (stateInfo.normalizedTime % 1f);

		if (currentTime > start && currentTime < end) {
			hitCollision.enabled = true;
		} else {	
			hitCollision.enabled = false;
		}
	}

	override public void OnStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		hitCollision.enabled = false;
	}
}
