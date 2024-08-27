using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomNumber : MonoBehaviour
{
	public Text[] elements;
	public List<string> variables = new List<string>();
 
    void Awake()
    {
    	for (int i = 0; i < elements.Length; i++)
    	{
        	string s = variables[Random.Range(0, variables.Count - 1)];
        	elements[i].text = s;
        	variables.Remove(s);
    	}
    }
}
