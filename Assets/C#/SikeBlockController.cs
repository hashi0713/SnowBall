using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SikeBlockController : MonoBehaviour
{
    [SerializeField] private float rotSpeed;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * rotSpeed);
    }
}
