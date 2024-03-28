using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 1, 4);
    }

    void SpawnAnimals()
        
    {
        int i = Random.Range(0, animalPrefabs.Length+1);
        Instantiate((animalPrefabs[i]),
            new Vector3(
                Random.Range(-18f, 18f),
                0.1f,
                Random.Range(20f, 30f)),
            animalPrefabs[i].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
