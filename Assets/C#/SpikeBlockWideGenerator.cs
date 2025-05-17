using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBlockWideGenerator : MonoBehaviour
{
    [SerializeField] private float span;
    [SerializeField] private GameObject obj;

    private float timer = 0;
    void Start()
    {
        timer = span;
    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if (timer >= span)
        {
            Instantiate(obj, transform.position, obj.transform.rotation);
            timer = 0;
        }
    }
}
