using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDirectir2 : MonoBehaviour
{
    [SerializeField] private EndScore end;
    [SerializeField] private GameObject[] uI;
    [SerializeField] private float activeTime;

    private float activeTimer;

    private bool isActive = false;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && end.stop || activeTimer >= activeTime)
        {
            isActive = true;
            activeTimer = 0;
        }
    }
    private void FixedUpdate()
    {
        if (!isActive && end.stop) activeTimer += Time.fixedDeltaTime;
        if (isActive)
        {
            foreach (GameObject obj in uI) obj.SetActive(true);
        }
    }
}
