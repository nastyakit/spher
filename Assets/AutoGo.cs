/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GoThere : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    Vector3 ta;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        agent = GetComponent<NavMeshAgent>();
        var to = GameObject.Find("target").transform.position;
        //var p = new NavMeshPath();
        //var x = agent.CalculatePath(to, p);

        ta = to;
    }

    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, to, step);
        agent.Move(ta);
    }
}
*/