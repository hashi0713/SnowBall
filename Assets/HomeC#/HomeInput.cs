using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class HomeInput : MonoBehaviour
{
    [SerializeField] private GameObject[] obj1;
    [SerializeField] private GameObject[] obj2;

    void Start()
    {
        
    }

    void Update()
    {
        var current = Keyboard.current;
        if (current == null) return;
        if (current.eKey.wasReleasedThisFrame)
        {
            SceneManager.LoadScene("Game1");
        }
        if (current.bKey.wasReleasedThisFrame)
        {
            foreach (GameObject button in obj1) button.SetActive(true);
            foreach (GameObject button in obj2) button.SetActive(false);
        }

        if (current.digit1Key.wasReleasedThisFrame||current.digit2Key.wasReleasedThisFrame|| current.digit3Key.wasReleasedThisFrame|| current.digit4Key.wasReleasedThisFrame|| current.digit5Key.wasReleasedThisFrame|| current.digit6Key.wasReleasedThisFrame|| current.digit7Key.wasReleasedThisFrame|| current.digit8Key.wasReleasedThisFrame|| current.digit9Key.wasReleasedThisFrame|| current.qKey.wasReleasedThisFrame|| current.wKey.wasReleasedThisFrame|| current.rKey.wasReleasedThisFrame|| current.tKey.wasReleasedThisFrame|| current.yKey.wasReleasedThisFrame|| current.uKey.wasReleasedThisFrame) SceneManager.LoadScene("Game2");
        if (current.digit1Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 0);
        if (current.digit2Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 1);
        if (current.digit3Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 2);
        if (current.digit4Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 3);
        if (current.digit5Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 4);
        if (current.digit6Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 5);
        if (current.digit7Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 6);
        if (current.digit8Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 7);
        if (current.digit9Key.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 8);
        if (current.qKey.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 9);
        if (current.wKey.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 10);
        if (current.rKey.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 11);
        if (current.tKey.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 12);
        if (current.yKey.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 13);
        if (current.uKey.wasReleasedThisFrame) PlayerPrefs.SetInt("Stage", 14);

        if (current.sKey.wasReleasedThisFrame)
        {
            foreach (GameObject button in obj1) button.SetActive(false);
            foreach (GameObject button in obj2) button.SetActive(true);
        }

        
    }
}
