using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Global
{
    public static int test;

}

public class GoThere : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    Vector3 me, neme;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        me = transform.position;

        /*
        if (Vector3.Distance(me, new Vector3(-1, 2, 1)) >= 1) {
            Global.test = 2;
            transform.position = new Vector3(0, 1, 0);
        }
        */

        neme = GameObject.Find("target").transform.position;
        if (Vector3.Distance(me, neme) <= 0.5)
        {
            Global.test = 2;
        }
        else
        {
            Global.test = 1;
        }
        transform.position = Vector3.MoveTowards(me, neme, Time.deltaTime * 2);
    }
}
