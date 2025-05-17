using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    [System.NonSerialized] public bool stop=false;

    [System.NonSerialized] public int score;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();

        stop = false;
        score = PlayerPrefs.GetInt("Score", 0);

    }
    private void Update()
    {
    }
    private void FixedUpdate()
    {
        if (score > 0)
        {
            score--;
            text.text = score.ToString() + "P";
        }
        if (score <= 0)
        {
            text.text = null;
            stop = true;
        }
    }
}
