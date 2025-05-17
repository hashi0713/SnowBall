using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inhale : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float rotSpeed = 0;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Rigidbody rd))
        {
            transform.Rotate(0,rotSpeed,0);
            Vector3 vec = new Vector3(transform.position.x - other.transform.position.x, 0, transform.position.z - other.transform.position.z);
            rd.AddForce(vec*force);
        }
    }
}
