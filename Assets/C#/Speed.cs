using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    private Text text;
    [SerializeField] private SnowBallController player;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Mathf.Sqrt(Mathf.Pow(player.rd.velocity.x, 2) + Mathf.Pow(player.rd.velocity.z, 2)).ToString();
    }
}
