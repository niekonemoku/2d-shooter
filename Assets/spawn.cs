using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // The enemy prefab to spawn
    public float minX = -10f; // Minimum X coordinate for spawn
    public float maxX = 10f;  // Maximum X coordinate for spawn
    public float minY = -5f;  // Minimum Y coordinate for spawn
    public float maxY = 5f;   // Maximum Y coordinate for spawn
    public float minSpawnTime = 2f; // Minimum time interval between spawns
    public float maxSpawnTime = 5f; // Maximum time interval between spawns

    private void Start()
    {
        // Start spawning enemies at random intervals
        Invoke("SpawnEnemy", Random.Range(minSpawnTime, maxSpawnTime));
    }

    // Function to spawn an enemy
    private void SpawnEnemy()
    {
        // Generate a random position within the defined x and y range
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f); // Set Z to 0 for 2D

        // Instantiate the enemy at the random position
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        // Repeat the spawn after a random time
        Invoke("SpawnEnemy", Random.Range(minSpawnTime, maxSpawnTime));
    }
}
