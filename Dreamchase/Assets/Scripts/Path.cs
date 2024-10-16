using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] Transform[] Points;

    [SerializeField] private float moveSpeed;

    private int pointsIndex; //telt de hoeveelheid waypoints er zijn

    private void Start()
    {
        transform.position = Points[pointsIndex].transform.position; 
    }

    private void Update()
    {
        if(pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

            if(transform.position == Points[pointsIndex].transform.position)
            {
                pointsIndex += 1; //er wordt hier telkens een waypoint bij geteld
            }

        }
    }
}
