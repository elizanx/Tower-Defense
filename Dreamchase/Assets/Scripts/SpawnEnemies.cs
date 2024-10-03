using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject BatAttacker;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPositon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject bat = Instantiate(BatAttacker, (Vector2)spawnPositon, Quaternion.identity);
        }   
    }
}
