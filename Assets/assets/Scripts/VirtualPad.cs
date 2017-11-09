using UnityEngine;
using System.Collections;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]

public class VirtualPad : MonoBehaviour
{
	public float moveSpeed = 5f;
	public GameObject padPrefab;

	UnityEngine.AI.NavMeshAgent agent;
	Animator anim;
	GameObject pad;
	float padSize = 150f;

	Vector2 center;
	Vector2 dir;

	Vector3 velocity;

	void Start ()
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Input.touchCount > 0) {
			var t = Input.GetTouch (0);

			if (t.phase == TouchPhase.Began) {
				center = t.position;

				if (padPrefab) {
					pad = Instantiate(padPrefab) as GameObject;
					pad.transform.SetParent(GameObject.Find("Canvas").transform);
					pad.transform.position = center;

					RectTransform rt = pad.GetComponent<RectTransform>();
					padSize = Mathf.Max(rt.sizeDelta.x, rt.sizeDelta.y);
				}
			}

			if (t.phase == TouchPhase.Moved) {
				dir = t.position - center;

				if (dir.magnitude > 20f) {
					velocity.x = Mathf.Min(dir.x, padSize) / padSize;
					velocity.z = Mathf.Min(dir.y, padSize) / padSize;
					
					velocity *= moveSpeed;
				}
			}

			if (t.phase == TouchPhase.Ended || t.phase == TouchPhase.Canceled) {
				center = Vector2.zero;
				dir = Vector2.zero;
				velocity = Vector3.zero;

				if (padPrefab) {
					Destroy(pad);
				}
			}
		}

		agent.Move (velocity * Time.deltaTime);
		anim.SetFloat("Speed", velocity.magnitude);
	}
}
