using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;


    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); //até essa linha faz com que ele ande em direção aos waypoints, mas só até o primeiro


        if(Vector3.Distance(transform.position, target.position) <= 0.4f) //distancia entre os pontos onde ele para/vai
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint() //faz com que ande para o proximo waypoint e destrói quando chegar no ultímo
    {
        if(wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++; 
        target = Waypoints.points[wavepointIndex];
    }
}
