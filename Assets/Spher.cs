using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spher : MonoBehaviour
{
   
    Rigidbody rb;
    public Panel panel;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.position.y < -2 || rb.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
