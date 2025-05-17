using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBoxController : MonoBehaviour
{
    [SerializeField] private float wide;

    private float speed = 0;
    private float timer = 0;
    private float startPos_x;

    private void Start()
    {
        startPos_x = transform.position.x;
        do
        {
            speed = Random.Range(-3, 3);

        } while (-1 < speed && speed < 1);
        
    }
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        transform.position = new Vector3(startPos_x + wide * Mathf.Sin(timer * speed), transform.position.y, transform.position.z);
    }
}
