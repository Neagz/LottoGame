using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLose2 : MonoBehaviour
{
    public GameObject[] evidenceTags;
    public GameObject loser;
    public GameObject restart;
    public int objCount;
    public AudioSource ballSound;
    private AudioSource loseSound;

    void Awake()
    {
        loseSound = GetComponent<AudioSource>();
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
        	loser.SetActive(true);
            restart.SetActive(true);
            ballSound.Stop();
            loseSound.Play();
        }
    }
}
