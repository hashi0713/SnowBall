using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBclock : MonoBehaviour
{
    private GameObject obj;
    [SerializeField] private Vector3 startPos;
    [SerializeField] private Vector3 endPos;
    [SerializeField] private float speed;

    private bool end=false;

    void Start()
    {
        obj = GameObject.Find("SnowBall");
        //transform.position = new Vector3(transform.position.x, startPos.y, 0);
    }

    void FixedUpdate()
    {
        if (transform.position.y <= endPos.y&&!end) transform.position = transform.position + Vector3.up * speed;
        if (transform.position.y > endPos.y&&!end) transform.position = new Vector3(transform.position.x, endPos.y, transform.position.z);
        if (transform.position.y == endPos.y) end = true;
        if (obj.transform.position.x > transform.position.x + 1&&end) transform.position = transform.position - Vector3.up * speed/2;
        if (end && transform.position.y < -15) Destroy(gameObject);
    }
}
