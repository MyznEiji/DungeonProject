using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BounceText : MonoBehaviour
{
	public Text bounceCharPrefab;
	public float delay = 0.5f;
	
	IEnumerator Start ()
	{
		var text = GetComponent<Text>();
		
		string msg = text.text;
		float offset = text.preferredWidth * -0.5f;
		text.text = "";
		
		for (int i = 0; i < msg.Length; i++) {
			var ch = Instantiate (bounceCharPrefab) as Text;
			
			ch.text = msg[i].ToString();
			ch.transform.SetParent(transform);
			
			Vector3 pos = transform.position;
			pos.x += offset;
			ch.transform.position = pos;
			
			offset += ch.preferredWidth;
			yield return new WaitForSeconds(delay);
		}
	}
	
	void Update () {}
}
