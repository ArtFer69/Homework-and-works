using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class agentedinamico : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform[] waypoint;
    public int indexWaypoint = 0;
   
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(waypoint[indexWaypoint].position);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance == 0)
        {
            indexWaypoint = (indexWaypoint + 1) % waypoint.Length;
            agent.SetDestination(waypoint[indexWaypoint].position);
        }
    }
}
