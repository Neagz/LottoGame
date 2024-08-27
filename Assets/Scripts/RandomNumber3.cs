using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class RandomNumber3 : MonoBehaviour
{
	public GameObject[] arrayOfGameObjects;
	void Start()
    {
        StartCoroutine(MyCounter(5));
    }
 
    IEnumerator MyCounter(int number)
    {
        int i = 0;
        while(i < number)
        {
        	GameObject selection = arrayOfGameObjects
			.Where(i=>!i.activeSelf)
			.OrderBy(n=>Random.value).FirstOrDefault();

			if (selection != null) selection.SetActive(true);

            yield return 0;
            i++;
        }
    }
}
