using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawnOne;
    public GameObject objectToSpawnTwo;
    public GameObject objectToSpawnTree;
    public float spawnRate = 0.59f;
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
        float rand = Random.Range(1, 1000);
        if (rand <= 45)
        {
            Instantiate(objectToSpawnOne, transform.position, Quaternion.identity); //спаун «олотого €блока
        }
        else if (rand > 45 && rand < 890)
        {
            Instantiate(objectToSpawnTwo, transform.position, Quaternion.identity); // спаун ќбычного €блока
        }
        else
        {
            Instantiate(objectToSpawnTree, transform.position, Quaternion.identity); // спаун ядовитого €блока
        }
    }
}
