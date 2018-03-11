using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawningPlanets : MonoBehaviour {

    List<GameObject> planetList = new List<GameObject>();
    public GameObject Planet1;
    public GameObject Planet2;
    public GameObject Planet3;
    public GameObject Planet4;
    public GameObject Spaceship;
    int planetCount;


    // Use this for initialization
    void Start () {
        planetList.Add(Planet1);
        planetList.Add(Planet2);
        planetList.Add(Planet3);
        planetList.Add(Planet4);
        planetList.Add(Spaceship);
        SpawnWaves();
    }

    void SpawnWaves()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5.06f, 5.06f), Random.Range(-5.67f, 5.67f), Random.Range(transform.position.z + 16f, transform.position.z + 44f));
            Quaternion spawnRotation = Quaternion.identity;
            int planetIndex = Random.Range(0, 5);
            Instantiate(planetList[planetIndex], spawnPosition, spawnRotation);
            planetCount++;
        }
    }

    void OnTriggerEnter(Collider collider1)
    {
        if (collider1.gameObject.tag == "Planets")
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5.06f, 5.06f), Random.Range(-5.67f, 5.67f), transform.position.z + 45f);
            Quaternion spawnRotation = Quaternion.identity;
            int planetIndex = Random.Range(0, 5);
            Instantiate(planetList[planetIndex], spawnPosition, spawnRotation);
            planetCount++;
            Destroy(collider1.gameObject);
            planetCount--;
        }
    }
}
