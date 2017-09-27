using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

//Я люблю Якушкина

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    bool l = false;
    bool r = false;
    Rigidbody rb;
    bool p = true;
    System.Random rand = new System.Random();

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (rb.position.y < 5)
        {
            if (Input.GetButtonDown("Jump"))
                rb.velocity = new Vector3(0, 5, 0);
        }
        if (!p) {
            transform.Translate(new Vector3(rand.Next(60) / 10 - 3, rand.Next(30) / 10, rand.Next(60) / 10 - 3) * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (p) p = false; else p = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, 4);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3(3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -4);
        }
    }
}
