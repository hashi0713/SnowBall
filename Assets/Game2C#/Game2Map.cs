using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2Map : MonoBehaviour
{
    [SerializeField] private GameObject[] map;

    void Start()
    {
        Instantiate(map[PlayerPrefs.GetInt("Stage", 1)], Vector3.zero, Quaternion.identity);
    }

}
