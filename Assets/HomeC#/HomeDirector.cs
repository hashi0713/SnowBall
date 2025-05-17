using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeDirector : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private GameObject road;
    private int count = 4;
    private const int dis = 1;
    void Start()
    {
        /*for(int i = 0; i < 15; i++)
        {
            //PlayerPrefs.SetInt("Goal" + i, 0);
            Debug.Log(i+":"+PlayerPrefs.GetInt("Goal" + i, 0));
        }*/
    }

    void Update()
    {
        if (obj.transform.position.x >= count-4)
        {
            Instantiate(road, new Vector3(count, -10, 0), Quaternion.identity);
            count += dis;
        }
    }
}
