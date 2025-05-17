using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float height;

    private float timer = 0;
    private float startpos_y = 0;
    private void Start()
    {
        startpos_y = transform.position.y;
    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        transform.position = new Vector3(transform.position.x, startpos_y + height * Mathf.Sin(timer * speed), transform.position.z);
    }
}
