using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomBalls : MonoBehaviour
{
	public Text[] elements;
	public List<string> variables = new List<string>();
	public GameObject ballPrediction;
	public Vector2 startPosition;

	private AudioSource ballSound;
	private Rigidbody2D rb;

 	void Awake()
 	{
 		ballSound = GetComponent<AudioSource>();
 		rb = GetComponent<Rigidbody2D>();
 	}

 	void Start()
 	{
 		rb.isKinematic = true;
 	}

    public void RandNumber()
    {
    	
    	for (int i = 0; i < elements.Length; i++)
    	{
        	string s = variables[Random.Range(0, variables.Count - 1)];
        	elements[i].text = s;
        	variables.Remove(s);
        	//ballSound.PlayDelayed(0.5f);
        	ballSound.Play();
			gameObject.transform.position = startPosition;
			rb.isKinematic = false;
    	}
    }
}