using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score=0;
    public TextMeshProUGUI scoretxt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {       //Adding 1 to the score
            score++;
            PlayerPrefs.SetInt("savedscore", score);
            Destroy(collision.gameObject);
            
        }
        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);

        }
    }
}
