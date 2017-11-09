using UnityEngine;
using System.Collections;

public class BoundsSize : MonoBehaviour
{
	void Start ()
	{
		var colls = GetComponentsInChildren<Collider> ();
		print(colls.Length);
		var b = new Bounds ();

		foreach (var c in colls) {
			b.Encapsulate (c.bounds);
			print (c.name);
			print (b);
		}

		var col = gameObject.AddComponent<BoxCollider> ();
		col.center = b.center;
		col.size = b.size;
	}

	void Update ()
	{
		
	}
}
