using UnityEngine;
using System.Collections;

public class ImageBasedMap : MonoBehaviour {

	public Texture2D mapImage;
	public GameObject chipPrefab;

	// Use this for initialization
	void Start () {
		for (int w = mapImage.width - 1; w >= 0 ; w--) {
			for (int h = mapImage.height - 1; h >= 0; h--) {
				if (mapImage.GetPixel (w, h) == Color.white) {
					var obj = Instantiate (chipPrefab, new Vector3 (w, 0, h), Quaternion.identity) as GameObject;
					obj.transform.parent = transform;
				}
			}	
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
