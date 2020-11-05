using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnRate = 2f;
    public float distFromCenter = 5f;
    float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time + spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > spawnTime)
		{
            Debug.Log("SPAWN");
            Vector2 randomPosOnCircle = Random.insideUnitCircle.normalized * distFromCenter;
            GameObject newPrefab = Instantiate(prefabToSpawn);
            newPrefab.transform.position = new Vector3(randomPosOnCircle.x, 0f, randomPosOnCircle.y);

            spawnTime = Time.time + spawnRate;
        }   
    }
}
