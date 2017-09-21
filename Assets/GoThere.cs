using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GoThere : MonoBehaviour
{
    public Transform target;
    public float speed;
    NavMeshAgent agent;
    /*
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        var to = GameObject.Find("target").transform.position;
        var p = new NavMeshPath();
        var x = agent.CalculatePath(to, p);

        while (true)
        {
            agent.Move(Vector3.MoveTowards(transform.position, to, Time.deltaTime));
        }
    }
    */
    void Update()
    {
        var to = GameObject.Find("target").transform.position;
        float step = Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, to, step);
    }
}
