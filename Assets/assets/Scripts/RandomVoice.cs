using UnityEngine;
using System.Collections;

public class RandomVoice : MonoBehaviour
{
	public AudioClip [] clips;

	IEnumerator Start ()
	{
		while (true) {
			GetComponent<AudioSource>().PlayOneShot(clips[Random.Range(0, clips.Length)]);
			yield return new WaitForSeconds(5f);
		}	                                            
	}
	
	void Update ()
	{
	
	}
}
