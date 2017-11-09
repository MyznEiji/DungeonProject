using UnityEngine;
using System.Collections;

public class SwipeAction : MonoBehaviour
{
	public float swipeThreshold = 500f;

	Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		foreach (var t in Input.touches) {
			if (t.deltaPosition.magnitude / Time.deltaTime > swipeThreshold) {
				anim.SetFloat ("SwipeDirectionX", t.deltaPosition.normalized.x);
				anim.SetFloat ("SwipeDirectionY", t.deltaPosition.normalized.y);
			Debug.Log(t.deltaPosition.magnitude/Time.deltaTime);
				return;
			}
		}

		anim.SetFloat ("SwipeDirectionX", 0);
		anim.SetFloat ("SwipeDirectionY", 0);
	}
}
