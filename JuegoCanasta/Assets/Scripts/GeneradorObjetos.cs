using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject[] objectosPrefab; 
    public float minX = -3f;
    public float maxX = 3f;
    public float maxY = 14f;
    public float minY = -4f;
    public float minInterval = 1f; 
    public float maxInterval = 5f; 

    void Start()
    {
        InvokeRepeating("SpawnObjects", Random.Range(minInterval, maxInterval), Random.Range(minInterval, maxInterval));
    }

    void SpawnObjects()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), maxY, -8f);
        int randomIndex = Random.Range(0, objectosPrefab.Length);
        GameObject spawnedObject = Instantiate(objectosPrefab[randomIndex], spawnPosition, Quaternion.identity);

        if (spawnedObject.transform.position.y < minY)
        {
            Destroy(spawnedObject);
        }
    }
}