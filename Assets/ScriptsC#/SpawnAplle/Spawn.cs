using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnRate = 0.66f;
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
