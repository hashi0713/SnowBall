using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalObject : MonoBehaviour
{
    [SerializeField] private Vector3 quo;

    private void FixedUpdate()
    {
        transform.Rotate(quo);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("Goal" + PlayerPrefs.GetInt("Stage", 0), 1);
        SceneManager.LoadScene("Score2");
    }
}
