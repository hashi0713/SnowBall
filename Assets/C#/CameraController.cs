using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector3 pos;

    public GameObject center;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (center.transform.position.y <= 0.5f)
        {
            transform.LookAt(center.transform.position);
            return;
        }
        transform.position = pos + center.transform.position;
    }
}
