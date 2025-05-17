using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out SnowBallController player))
        {
            player.rd.AddForce(new Vector3(0, jumpForce, 0),ForceMode.VelocityChange);
        }       
    }
}
