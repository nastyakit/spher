using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    //Vector3 pos = new Vector3(0,0,0);
    bool l = false;
    bool r = false;
    Rigidbody rb;
    bool p = true;
    System.Random rand = new System.Random();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(h * speed, rb.velocity.y, v * speed);   //rb.velocity.y
        //rb.AddForce(movement);

        if (rb.position.y < 5)
        { //Высота прыжка
            if (Input.GetButtonDown("Jump"))
                rb.velocity = new Vector3(rand.Next(50) / 10, rand.Next(50) / 10, 0);
        }
        if (!p)
            transform.Translate(new Vector3(2, 2, 0) * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (p) p = false; else p = true;
            /*
            rb.velocity = new Vector3(-5, 0, 0);
            Thread.Sleep(90);
            rb.velocity = new Vector3(0, 0, 7);
            Thread.Sleep(10);*/
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, 4);
            //pos = new Vector3(rb.position.x, rb.position.y, rb.position.z + 5);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-3, 0, 0);
            //pos = new Vector3(rb.position.x - 5, rb.position.y, rb.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //DateTime tim = DateTime.Now;
            rb.velocity = new Vector3(3, 0, 0);
            //pos = new Vector3(rb.position.x + 5, rb.position.y, rb.position.z);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //DateTime tim = DateTime.Now;
            rb.velocity = new Vector3(0, 0, -4);
            /* 
            Renderer b = rb.GetComponent<Renderer>();
            Color c = Color.red;
            b.material = c;*/
            //pos = new Vector3(rb.position.x + 5, rb.position.y, rb.position.z);
        }
        //DateTime x = DateTime.Now;
    }
}
