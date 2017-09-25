using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rand : MonoBehaviour
{
    System.Random rand = new System.Random();
    private bool enter = false;

    void Start () {
        transform.position = new Vector3(-3, 1, 5);
	}
	
	void Update ()
    {
        //if (enter == false)
            StartCoroutine(your_timer());
        transform.position = new Vector3(rand.Next(8) - 4, 1, rand.Next(8) - 2);
    }

    IEnumerator your_timer()
    {
        enter = true;
        yield return new WaitForSeconds(20);
        enter = false;
    }
}
