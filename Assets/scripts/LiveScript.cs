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
    int speed = 5;
    IEnumerator DoSomething()
    {
        speed = speed * 2;
        yield return new WaitForSeconds(5f);
        speed = 5;
    }
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            StartCoroutine("DoSomething");
        }
    }
}
