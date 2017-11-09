using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LocalizeText : MonoBehaviour
{
	public string lang;

	Text text;
	Dictionary<string, string> dict = new Dictionary<string, string> ();

	void Start ()
	{
		if (lang == "") {
			lang = Application.systemLanguage.ToString ();
		}

		string [] translations = Resources.Load ("Text/" + lang).ToString ().Split (new char[]{'\n'}, System.StringSplitOptions.RemoveEmptyEntries);

		foreach (var str in translations) {
			string [] msg = str.Split (new char[]{'\t'}, System.StringSplitOptions.RemoveEmptyEntries);
			dict [msg [0]] = msg [1];
		}

		foreach (var t in gameObject.GetComponentsInChildren<Text>()) {
			string target;
			if (dict.TryGetValue (t.text, out target)) {
				t.text = target;
			}
		}
	}
	
	void Update ()
	{
	
	}
}
