using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{

    public Transform[] waypoints;
    public float speed;

    private NavMeshAgent agent;
    private int currentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(waypoints[currentWaypoint].position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * Time.deltaTime * speed);
        moveToNextWaypoint();
    }

    private void moveToNextWaypoint()
    {
        float distance = Vector3.Distance(waypoints[currentWaypoint].position, transform.position);
        Vector3 nextWaypoint = waypoints[currentWaypoint + 1].position;

        if (distance < waypoints.Length)
        {

        }
    }
}
