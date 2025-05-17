using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector : MonoBehaviour
{
    [SerializeField] private GameObject camera1;
    [SerializeField] private GameObject camera2;
    [SerializeField] private EndScore end;
    void Update()
    {
        if (!end.stop)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
        if (end.stop)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
    }
}
