using UnityEngine;
using UnityStandardAssets.ImageEffects;
using System.Collections;

public class Pause : MonoBehaviour
{
	bool isPause;
	GameObject hoge;

	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (isPause) {
				isPause = false;
				Time.timeScale = 1f;
			} else {
				isPause = true;
				Time.timeScale = 0;
			}

			Camera.main.GetComponent<Animator>().SetBool("isPause", isPause);
		}
	}
}
