using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    const float MAXHEALTH = 100f;
    float health;

    private void Start()
    {
        health = MAXHEALTH;
    }

    void Die()
    {
        GetComponent<CharacterController2D>().enabled = false;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            health = 0;
            Die();
        }
<<<<<<< Updated upstream
=======
        Updated upstream
        // UPDATE THE SLIDER
        healthSlider.value = health / MAXHEALTH;
        // Other code

        GetComponent<AudioSource>().Play();
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
        Stashed changes
>>>>>>> Stashed changes
    }
}
