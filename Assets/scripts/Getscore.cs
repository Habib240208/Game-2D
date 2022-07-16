using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Getscore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    void Update()
    {
        score.text = PlayerPrefs.GetInt("savedscore").ToString();
        highScore.text = PlayerPrefs.GetInt("Highscore").ToString();
    }
}
