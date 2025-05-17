using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall_2 : MonoBehaviour
{
    [SerializeField] private GameObject[] face;
    [SerializeField] private EndScore end;

    [SerializeField] private float localSpeed;

    [SerializeField] private Vector3 pos;

    private bool stop = false;

    private Vector3 dis;

    void Start()
    {
        foreach (GameObject obj in face) obj.gameObject.SetActive(false);
        dis = pos-transform.position;
    }

    private void FixedUpdate()
    {
        if (end.stop)
        {
            if(transform.localPosition.y<pos.y)transform.localPosition += dis / localSpeed;
            if (transform.localPosition.y >= pos.y) stop = true;
            if (stop)
            {
                transform.localPosition = pos;
                foreach (GameObject obj in face) obj.gameObject.SetActive(true);
            }
        }
    }
}
