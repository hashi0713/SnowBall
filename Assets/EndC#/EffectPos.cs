using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectPos : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private Vector3 pos;

    void Update()
    {
        transform.position = obj.transform.position + pos;
    }
}
