using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScore : MonoBehaviour
{
    private int score;
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
        score = PlayerPrefs.GetInt("HighScore", 0);
        text.text = "HighScore\n" + score + "P";
    }

    void Update()
    {
        
    }
}
