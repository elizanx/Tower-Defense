using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class Enemy : MonoBehaviour
{
    public float currentHealth = 100f;
    public float maxHealth = 100f;

    [SerializeField] private Slider healthSlider;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void TakeDamage(float DamageAmount)
    {
        currentHealth -= DamageAmount;
        healthSlider.value = currentHealth;
        
        if (currentHealth <= 0)
        {
            Die();
            SceneManager.LoadScene("Win");
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }

    
}

