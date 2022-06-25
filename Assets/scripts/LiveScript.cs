using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveScript : MonoBehaviour
{

    public float healthToGain = 5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthManager>().TakeHealth(healthToGain);
            Destroy(gameObject);
        }
    }
}
