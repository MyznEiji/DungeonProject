using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class SoundEffect : MonoBehaviour
{
	AudioSource audioSource;
	
	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
		audioSource.playOnAwake = false;
	}
	
	void PlaySfx (AudioClip clip)
	{
		audioSource.PlayOneShot (clip);
	}
}
