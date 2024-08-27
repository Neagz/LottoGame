using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensSpeed : MonoBehaviour
{
	public float speed = 0;
	public GameObject lens;

    public void Update()
    {
    	if (speed > 0)
    	{
        	gameObject.transform.Rotate(transform.forward * -speed);
			speed -= Time.deltaTime;
		}
    }

    public void SpeedWhell()
    {
    	speed = 20;
    }
}
