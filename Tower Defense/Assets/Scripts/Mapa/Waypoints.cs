using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] points;

    void Awake()
    {
        points = new Transform[transform.childCount]; //transformando os points para pegar os filhos e não o pai
        for(int i = 0; i <points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
