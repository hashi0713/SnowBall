using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private UIDirector uI;
    void Start()
    {
        
    }

    void Update()
    {
        var currentButton = Keyboard.current;
        if (currentButton == null) return;
        if (currentButton.rKey.wasReleasedThisFrame)
        {
            SceneManager.LoadScene("Game1");
        }
        if (currentButton.hKey.wasReleasedThisFrame)
        {
            SceneManager.LoadScene("Home");
        }
        if (currentButton.cKey.wasReleasedThisFrame)
        {
            uI.cameraMode = true;
        }
    }
}
