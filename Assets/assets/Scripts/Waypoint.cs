using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour
{
	public Transform next;

	void Start ()
	{
	
	}
	
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider other)
	{
		other.GetComponent<UnityEngine.AI.NavMeshAgent> ().SetDestination (next.position);
	}
}
