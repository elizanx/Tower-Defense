using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    [SerializeField]
    private GameObject healthBar;
    private Vector3 startScale;

    public Vector2 targetPos;


    // Start is called before the first frame update
    void Start()
    {
        startScale = healthBar.transform.localScale;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

   
    public void OnDamage(int damageAmount)
    {
        //100 hp = schaal 1
        //50 hp = schaal .5
        //20hp = schaal .2

        //100 hp = 4
        //50 hp = 2
        //20 hp = .8

        currentHealth -= damageAmount;
        healthBar.transform.localScale = new Vector3(startScale.x / 100 * currentHealth, startScale.y, startScale.z);
    }
}
