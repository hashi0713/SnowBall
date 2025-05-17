using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        var currentButton = Keyboard.current;
        if (currentButton == null) return;
        if (currentButton.rKey.wasReleasedThisFrame)
        {
            SceneManager.LoadScene("Game2");
        }
        if (currentButton.hKey.wasReleasedThisFrame)
        {
            SceneManager.LoadScene("Home");
        }
    }
}
