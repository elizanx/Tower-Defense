using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public float currentHealth = 100f;
    public float maxHealth = 100f;

    [SerializeField] private Slider healthSlider;

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
        }
    }
    public void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Win");
    }

    
}

