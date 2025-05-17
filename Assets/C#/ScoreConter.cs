using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreConter : MonoBehaviour
{
    [SerializeField] private GameObject player;

    //[System.NonSerialized]
    public int score = 0;

    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (score <= player.transform.position.z)
        {
            if(player.gameObject.TryGetComponent(out SnowBallController ball))
            {
                if(ball.isTouch)score = (int)player.transform.position.z;
            }                
        }

        text.text = score.ToString() + "P";
    }
}
