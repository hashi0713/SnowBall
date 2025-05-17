using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDirector : MonoBehaviour
{
    [System.NonSerialized] public bool cameraMode = false;

    [SerializeField] private EndScore end;
    [SerializeField] private GameObject[] uI;
    [SerializeField]private Text bestScore;
    [SerializeField]private Text myScore;
    [SerializeField] private float activeTime;

    private float activeTimer;

    private bool isActive=false;
    private bool oneTime = false;



    void Start()
    {
        bestScore.text = "HighScore:"+PlayerPrefs.GetInt("HighScore", 0).ToString() + "P";
        myScore.text = PlayerPrefs.GetInt("Score", 0).ToString() + "P";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&end.stop||activeTimer>=activeTime)
        {
            isActive = true;
            activeTimer = 0;
        }
        if (cameraMode && Input.GetMouseButtonDown(0)) cameraMode = false;
    }
    private void FixedUpdate()
    {
        if (!isActive&&end.stop) activeTimer += Time.fixedDeltaTime;
        if (isActive) foreach (GameObject obj in uI) obj.SetActive(true);
        if (cameraMode)
        {
            foreach (GameObject obj in uI) obj.SetActive(false);
            oneTime = true;
        }
        if (!cameraMode && oneTime)
        {
            oneTime = false;
            foreach (GameObject obj in uI) obj.SetActive(true);
        }
    }
}
