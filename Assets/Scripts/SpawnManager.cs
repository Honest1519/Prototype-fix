using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }
    private float spawnRangeX = 10;
    private float spawnRangeZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandomAnimal()
    {
            int animalIndex = Random.Range(0, animalPreFabs.Length);
             Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

            Instantiate(animalPreFabs[animalIndex], spawnPos, animalPreFabs[animalIndex].transform.rotation);
    }
}
