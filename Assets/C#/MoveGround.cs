using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float wide;

    private float timer = 0;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        transform.position = new Vector3(startPos.x, startPos.y, startPos.z + wide * Mathf.Sin(timer * speed));
    }
}
