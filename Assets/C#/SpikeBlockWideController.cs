using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBlockWideController : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float destroyDis;

    private Rigidbody rd;
    private float startPos_z;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        startPos_z = transform.position.z;
    }

    void Update()
    {
        rd.AddForce(Vector3.forward * force);
        if (startPos_z - destroyDis >= transform.position.z) Destroy(gameObject);
    }
}
