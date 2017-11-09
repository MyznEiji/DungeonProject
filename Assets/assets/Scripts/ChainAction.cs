using UnityEngine;
using System.Collections;

public class ChainAction : StateMachineBehaviour
{
	public float startTime;
	public float endTime;
	
	override public void OnStateUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		// "stateInfo.normalizedTime % 1f"は stateInfo.normalizedTimeが1以上になった時に0に戻してくれる
		float currentTime = stateInfo.length * (stateInfo.normalizedTime % 1f); 
		if (Input.GetKeyDown(KeyCode.Space) && currentTime > startTime && currentTime < endTime) {
			animator.SetTrigger ("ChainSucceed");
		}
	}
	
	override public void OnStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.ResetTrigger ("ChainSucceed");
	}
}
