using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreScript : MonoBehaviour
{

    public TMP_Text highScoreText;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }
}
