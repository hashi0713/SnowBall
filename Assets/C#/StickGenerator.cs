using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickGenerator : MonoBehaviour
{
    [SerializeField] private GameObject stick;

    private Vector3 pos;

    void Start()
    {
        stick.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            stick.SetActive(true);
            stick.transform.position = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            stick.SetActive(false);
        }
    }
}
