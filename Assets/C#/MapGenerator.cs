using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] map;
    [SerializeField] private GameObject player;

    private GameObject[] gameObjects;

    private int nom = 0;

    private int rand = 0;
    private int[] lastNom = new int[3];

    private const int distance = 20;
    private int pos =0;

    void Start()
    {
        foreach (GameObject root in map) nom++;
        lastNom[0] = lastNom[1] = lastNom[2] = nom;
    }

    void Update()
    {
        if (player.transform.position.z >= pos-distance)
        {
            do
            {
                rand = Random.Range(0, nom);
            } while (rand == lastNom[0] || rand == lastNom[1] || rand == lastNom[2]);
            lastNom[2] = lastNom[1];
            lastNom[1] = lastNom[0];
            lastNom[0] = rand;
            Instantiate(map[rand], new Vector3(0, 0, pos), Quaternion.identity);
            pos += distance;

            gameObjects = GameObject.FindGameObjectsWithTag("Root");
            foreach(GameObject root in gameObjects)
            {

                if (root.transform.position.z <= player.transform.position.z - 40) Destroy(root);
            }
        }
    }
}
