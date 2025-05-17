using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall_1 : MonoBehaviour
{
    [SerializeField] private EndScore end;

    [SerializeField] private float scaleSpeed;
    [SerializeField] private float maxSpeed;

    private Rigidbody rd;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !end.stop) { transform.localScale += Vector3.one * (end.score-1)*scaleSpeed; end.score = 0; }
    }
    void FixedUpdate()
    {
        
        if (Mathf.Abs(rd.velocity.y) >= maxSpeed) rd.velocity = new Vector3(0, -maxSpeed, 0);
        if (!end.stop)
        {
            transform.localScale += Vector3.one * scaleSpeed;
        }
        if (end.stop)
        {
            rd.velocity = Vector3.zero;
            rd.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
