using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
	public GameObject[] evidenceTags;
	public GameObject winner;
	public GameObject restart;
	public int objCount;
    public AudioSource ballSound;
    private AudioSource winSound;

    void Awake()
    {
        winSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        objCount= 0;
        foreach(GameObject go in evidenceTags)
        {
            if(go.activeSelf)
            {
                objCount++;
            }
        }

        if(objCount == 30)
        {
        	winner.SetActive(true);
        	restart.SetActive(true);
            ballSound.Stop();
            winSound.Play();
        }
    }
}
