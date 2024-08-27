using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPaints : MonoBehaviour
{
	private AudioSource paintSound;

 	void Awake()
 	{
 		paintSound = GetComponent<AudioSource>();
 	}

    public void PlayAudioPaints()
    {
        paintSound.Play();
    }
}
