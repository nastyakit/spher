using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform EndPoint;
    bool m = true;
    Vector3 StartPoint;

    void Start ()
    {
        StartPoint = transform.position;
    }

	void Update () {
        if (m==true && transform.position==EndPoint.position)
        {
            m = false;
        }
        else if (m==false && transform.position==StartPoint)
        {
            m = true;
        }
        if (m) {
            transform.position = Vector3.MoveTowards(transform.position, EndPoint.position, Time.deltaTime/4);
        }
        else {
            transform.position = Vector3.MoveTowards(transform.position, StartPoint, Time.deltaTime);
        }
    }
}
