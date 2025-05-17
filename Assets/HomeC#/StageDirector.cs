using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageDirector : MonoBehaviour
{
    [SerializeField] private GameObject[] road;
    private int count = 0;
    void Start()
    {
        foreach (GameObject obj in road)count++;
        for(int i = 0; i < count; i++)
        {
            if (PlayerPrefs.GetInt("Goal" + i, 0) == 1)
            {
                road[i].GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
            }

        }
    }
}
