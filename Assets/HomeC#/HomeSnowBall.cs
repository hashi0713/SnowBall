using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeSnowBall : MonoBehaviour
{
    [System.NonSerialized]public bool isStart=false;
    [SerializeField] private float speed;

    private Rigidbody rd;



    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isStart) rd.velocity = new Vector3(speed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isStart = true;
    }
}
