using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rand : MonoBehaviour
{
    System.Random rand = new System.Random();
    private bool enter = false;

    void Start ()
    {
        DontDestroyOnLoad(this);
        transform.position = new Vector3(-3, 1, 5);
	}
	
	void Update ()
    {
        if (Global.test == 2)
        { 
            transform.position = new Vector3(rand.Next(6) - 3, 1, rand.Next(6) - 1);
        }
    }
}