using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeCamera : MonoBehaviour
{
    [SerializeField] private HomeSnowBall ball;
    [SerializeField] private GameObject obj;
    [SerializeField] private Vector3 startPos;
    [SerializeField] private Vector3 endPos;
    [SerializeField] private float speed;
    private Vector3 pos;

    void Start()
    {
        pos = startPos;

    }

    void FixedUpdate()
    {
        if(!ball.isStart) transform.position=new Vector3(obj.transform.position.x + startPos.x, startPos.y, startPos.z);
        if (ball.isStart && pos.x >= endPos.x)
        {
            pos += Vector3.left * speed;
            transform.position = new Vector3(obj.transform.position.x + pos.x, pos.y, pos.z);
        }
        if (pos.x < endPos.x)
        {
            pos = endPos;
        }
    }
}
