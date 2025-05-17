using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private Vector3 vec;
    [SerializeField] private float test;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos = new Vector3(0, -PlayerPrefs.GetInt("Score", 0), 0);
        transform.position = obj.transform.position + vec + pos * test ;
    }
}


