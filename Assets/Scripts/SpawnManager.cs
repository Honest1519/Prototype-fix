using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPreFabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.S)) {
            // "Randomly generate the animal index and spawn position" - Unity tutorial
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            int animalIndex = Random.Range(0, animalPreFabs.Length);
            Instantiate(animalPreFabs[animalIndex], spawnPos, animalPreFabs[animalIndex].transform.rotation);
        }
    }
}
