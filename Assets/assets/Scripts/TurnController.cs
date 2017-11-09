using UnityEngine;
using System.Collections;

public class TurnController : MonoBehaviour
{
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			var c = transform.GetChild(0);
			c.SetAsLastSibling();
		}
	}
}
