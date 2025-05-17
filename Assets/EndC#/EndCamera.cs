using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCamera : MonoBehaviour
{
    [SerializeField] private GameObject[] obj;
    [SerializeField] private GameObject[] effect;
    [SerializeField] private Vector3[] pos;
    [SerializeField] private Vector3[] rot;

    [SerializeField] private EndScore end;

    void Start()
    {
        if (!end.stop)
        {
            transform.position = obj[0].transform.position + pos[0];
            transform.rotation = Quaternion.Euler(rot[0]);
            effect[0].SetActive(true);
        }
        if (end.stop)
        {
            effect[0].SetActive(false);
        }
    }

    void Update()
    {
        if (!end.stop)
        {
            transform.position = obj[0].transform.position + pos[0];
            transform.rotation = Quaternion.Euler(rot[0]);
            effect[0].SetActive(true);
        }
        if (end.stop)
        {
            effect[0].SetActive(false);
        }
    }
}
