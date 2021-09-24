using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject[] spawnPoints;
    [SerializeField]
    GameObject[] objectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        foreach (GameObject spawn in spawnPoints)
        {
            GameObject spawnObj = Instantiate(objectPrefab, spawn.transform, false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}