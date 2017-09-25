using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
//using System.Diagnostics;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform EndPoint;
    //System.Diagnostics.Stopwatch sw = new Stopwatch();
    //int k = 0;
    bool m = true;
    Vector3 StartPoint;

    void Start ()
    {
        StartPoint = transform.position;
    }

	void Update () {
        //k += 1;
        //sw.Stop();
        //if ((sw.ElapsedMilliseconds / 100.0) % 2 == 0) { 
        //if (k % 2 == 1) {
        if (m==true && transform.position==EndPoint.position)
        {
            m = false;
        }
        else if (m==false && transform.position==StartPoint)
        {
            m = true;
        }
        if (m) {
            transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, Time.deltaTime);
        }
        else {
            transform.position = Vector3.MoveTowards(transform.position, StartPoint, Time.deltaTime);
        }
    }
}
