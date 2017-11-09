using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Life : MonoBehaviour
{
	public float life = 100f;
	public float maxLife = 100f;

	public Slider meterPrefab;
	public Vector2 offset;	

	Slider meter;

	void Start ()
	{
		meter = Instantiate (meterPrefab) as Slider;
		meter.transform.SetParent (GameObject.Find ("Canvas").transform);
	}
	
	void Update ()
	{
		meter.transform.position = Camera.main.WorldToScreenPoint (transform.position) + new Vector3(offset.x, offset.y);
		meter.value = life / maxLife;
	}
}
