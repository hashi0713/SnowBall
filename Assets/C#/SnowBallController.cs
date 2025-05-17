using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SnowBallController : MonoBehaviour
{
    [SerializeField] private float moveForce_z;
    [SerializeField] private float moveForce_x;
    [SerializeField] private float maxSpeed;
    private float move_z=0;
    private float move_x=0;


    [System.NonSerialized]public Rigidbody rd;
    [System.NonSerialized] public bool isTouch;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var currentButton = Keyboard.current;
        if (currentButton == null) return;
        var wButton = currentButton[Key.W];
        var aButton = currentButton[Key.A];
        var sButton = currentButton[Key.S];
        var dButton = currentButton[Key.D];

        if (wButton.isPressed) move_x = -1;
        if (sButton.isPressed) move_x = 1;
        if (aButton.isPressed) move_z = -1;
        if (dButton.isPressed) move_z = 1;
    }

    private void FixedUpdate()
    {
        rd.AddForce(new Vector3(moveForce_x * move_x, 0, moveForce_z * move_z), ForceMode.VelocityChange);
        move_x = move_z = 0;
    }

    private void OnCollisionStay(Collision collision)
    {
        isTouch = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isTouch = false;
    }
}
