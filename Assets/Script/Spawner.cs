using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public float spawnDelay;
    private float nextSpawn = 0.0f;
    private float minX = -14f;
    private float maxX = 15f;
    private int height = 6;

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;

            // Generate a random index to select a random object
            int randomIndex = Random.Range(0, objectsToSpawn.Length);

            // Get the randomly selected object from the array
            GameObject objectToSpawn = objectsToSpawn[randomIndex];

            // Generate a random X position
            float randomX = Random.Range(minX, maxX);

            if (randomX < 3 && randomX>-3) {
                randomX = Random.Range(minX, maxX);
            }

            // Set the spawn position
            Vector3 spawnPosition = new Vector3(randomX, height, transform.position.z);

            // Spawn the selected object at the random position
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        }

    }
}