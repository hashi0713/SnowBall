using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private GameObject[] effect;

    [SerializeField] private ScoreConter score;

    private bool gameOver=false;

    void Start()
    {
        
    }

    void Update()
    {
        if (obj.transform.position.y < -15) gameOver = true;
        if (gameOver)
        {
            PlayerPrefs.SetInt("Score", score.score);
            if (PlayerPrefs.GetInt("HighScore", 0) < score.score) PlayerPrefs.SetInt("HighScore", score.score);
            foreach (GameObject eff in effect) Destroy(eff);
            SceneManager.LoadScene("Score");
        }
    }
}
