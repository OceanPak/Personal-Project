using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpawningAsteroids : MonoBehaviour {

    List<GameObject> prefabList = new List<GameObject>();
    public GameObject hazard;
    public GameObject hazard2;
    public GameObject hazard3;
    public int hazardCount;
    int asteroidCount;
    public float waveWait;

    // Use this for initialization
    void Start() {
        prefabList.Add(hazard);
        prefabList.Add(hazard2);
        prefabList.Add(hazard3);
        SpawnWaves();
        StartCoroutine(SecondWaves());
    }

    void SpawnWaves()
    {
        for (int i = 0; i < hazardCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5.06f, 5.06f), Random.Range(-5.67f, 5.67f), Random.Range(transform.position.z + 8f, transform.position.z + 44f));
            Quaternion spawnRotation = Quaternion.identity;
            int prefabIndex = Random.Range(0, 3);
            Instantiate(prefabList[prefabIndex], spawnPosition, spawnRotation);
            asteroidCount++;
        }
    }

    void OnTriggerEnter(Collider collider1)
    {
        if (collider1.gameObject.tag == "Asteroid")
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5.06f, 5.06f), Random.Range(-5.67f, 5.67f), transform.position.z + 45f);
            Quaternion spawnRotation = Quaternion.identity;
            int prefabIndex = Random.Range(0, 3);
            Instantiate(prefabList[prefabIndex], spawnPosition, spawnRotation);
            asteroidCount++;
            Destroy(collider1.gameObject);
            asteroidCount--;
        }
    }

    IEnumerator SecondWaves ()
    {
        while (true)
        {
            for (int i = 0; i < 15; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-5.06f, 5.06f), Random.Range(-5.67f, 5.67f), Random.Range(transform.position.z + 45f, transform.position.z + 81f));
                Quaternion spawnRotation = Quaternion.identity;
                int prefabIndex = Random.Range(0, 3);
                Instantiate(prefabList[prefabIndex], spawnPosition, spawnRotation);
                asteroidCount++;
            }
            print(asteroidCount);
            yield return new WaitForSeconds(waveWait);
        }
    }
}
