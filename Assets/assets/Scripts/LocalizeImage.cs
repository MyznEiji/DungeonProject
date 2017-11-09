using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LocalizeImage : MonoBehaviour
{
	public string lang;
	public Sprite sprite;

	void Start ()
	{
		if (lang == "") {
			lang = Application.systemLanguage.ToString ();
		}

		byte [] data = Resources.Load<Texture2D> ("UI/" + lang).EncodeToPNG ();
		sprite.texture.LoadImage (data);
	}
	
	void Update () {

	}
}
