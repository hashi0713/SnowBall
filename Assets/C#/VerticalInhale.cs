using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalInhale : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float rotSpeed;
    [SerializeField] private float speed;
    [SerializeField] private float wide;

    private float timer = 0;
    private float startPos_y;

    private void Start()
    {
        startPos_y = transform.position.y;
        
    }
    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        transform.position = new Vector3(transform.position.x, startPos_y + wide * Mathf.Sin(timer * speed), transform.position.z);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Rigidbody rd))
        {
            transform.Rotate(0, rotSpeed, 0);
            Vector3 vec = new Vector3(0, transform.position.y - other.transform.position.y, 0);
            rd.AddForce(vec * force);
        }
    }
}
