using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGame : MonoBehaviour
{
	private AudioSource gameSound;

 	void Awake()
 	{
 		gameSound = GetComponent<AudioSource>();
 	}

    void Start()
    {
        gameSound.Play();
    }
}
