using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashBlock : MonoBehaviour
{
    [SerializeField] private float dashForce;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out SnowBallController player))
        {
            player.rd.AddForce(transform.forward * dashForce, ForceMode.VelocityChange);
        }
    }
}
