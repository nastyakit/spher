using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour {
    public Transform EndPoint;
    //Rigidbody rk;
    //System.Random rand = new System.Random();

    void Start ()
    {
        //GetComponent<Renderer>().material.color = Color.green;
        //rk = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //rk.velocity = new Vector3(0, 5, 0);
        //transform.Translate(new Vector3(rand.Next(60) / 10 - 3, rand.Next(30) / 10, rand.Next(60) / 10 - 3) * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, Time.deltaTime);
    }
}
