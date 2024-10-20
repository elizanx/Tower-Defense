using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Aim : MonoBehaviour
{
    [SerializeField] Bullet bullet;
    Vector3 mousePosition;
    float angle = 0;

    

    //Alleen voor tower!
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition = new Vector3(mousePosition.x, mousePosition.y, 0);

            Vector3 differenceVector = mousePosition - transform.position;

            angle = Mathf.Atan2(differenceVector.y, differenceVector.x);
            angle = angle * Mathf.Rad2Deg;

            //Debug.Log(differenceVector);

            Bullet copybullet = Instantiate(bullet, transform.position, Quaternion.identity);
            copybullet.angle = angle;
        }
    }
}
