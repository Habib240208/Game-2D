using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthManager : MonoBehaviour
{
    const float MAXHEALTH = 100f;
    public float health;
    public Slider healthSlider;

    private void Start()
    {
        health = MAXHEALTH;
    }

    void Die()
    {
        GetComponent<CharacterController2D>().enabled = false;
        GetComponentInChildren<Animator>().SetBool("dead", true);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            health = 0;
            Die();
        }
        // UPDATE THE SLIDER
        healthSlider.value = health / MAXHEALTH;
    }
    public void TakeHealth(float amount)
    {
        health += amount;

        if (health >=100)
        {
            health = 100;
        }
        // UPDATE THE SLIDER
        healthSlider.value = health / MAXHEALTH;
    }
}

