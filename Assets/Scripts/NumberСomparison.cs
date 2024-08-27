using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberСomparison : MonoBehaviour
{
	public Text a;
	public Text b;
	public GameObject btn;


	void Update()
	{
		if (a.text == b.text)
		{
			btn.SetActive(true);
		}
	}
}
