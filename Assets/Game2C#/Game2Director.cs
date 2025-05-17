using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game2Director : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    void Start()
    {
        
    }

    void Update()
    {

        if (obj.transform.position.y < -10)
        {
            SceneManager.LoadScene("Home");
        }
    }
}
