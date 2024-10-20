using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject ghost;

    [SerializeField]
    public float speed;
    private void Start()
    {

    }

    private void Update()
    {
        Movement();
        
    }


    private void Movement()
    {
        Vector3 Walk = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ghost.transform.position += Walk * speed * Time.deltaTime;
    }
}
