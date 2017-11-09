using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class VolumeSettings : MonoBehaviour
{
	public AudioMixer mixer;

	void Start ()
	{

	}

	void Update () 
	{

	}
	
	public void ChangeMusicVolume (float vol)
	{
		mixer.SetFloat ("MusicVolume", vol);
	}

	public void ChangeSfxVolume (float vol)
	{
		mixer.SetFloat ("SfxVolume", vol);
	}
}
