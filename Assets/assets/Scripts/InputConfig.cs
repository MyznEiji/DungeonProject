using UnityEngine;
using System;
using System.Collections;

public class InputConfig : MonoBehaviour
{
	void Start () {}
	
	void Update ()
	{
		if (Input.anyKeyDown) {
			print (ScanKeyCode ());
		}
	}

	KeyCode ScanKeyCode ()
	{
		foreach (KeyCode code in Enum.GetValues (typeof(KeyCode))) {
			if (Input.GetKeyDown (code)) {
				return code;
			}
		}

		return KeyCode.None;
	}
}
