using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorOff : MonoBehaviour
{
	[SerializeField] float timer;
    [SerializeField] GameObject obj;

    float elapsedTime = 0.0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > timer)
        {
            obj.SetActive(false);
        }
    }
}
