using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemyPrefab;

    private int numberOfEnemiesToSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberOfEnemiesToSpawn = getnumberOfEnemiesToSpawn();
        SpawnEnemies();
    }

    private int getnumberOfEnemiesToSpawn()
    {
        return GameManager.Instance.GetNumberOfEnemiesToSpawn();
    }

    private void SpawnEnemies()
    {
        List<Transform> availableSpawnPoints = new List<Transform>(spawnPoints);

        for (int i = 0; i < numberOfEnemiesToSpawn; i++)
        {
            // Pick a random spawn point
            int randomIndex = Random.Range(0, availableSpawnPoints.Count);

            Transform chosenSpawnPoint = availableSpawnPoints[randomIndex];

            // Spawn enemy
            Instantiate(enemyPrefab, chosenSpawnPoint.position, Quaternion.identity);

            // Remove used spawn point so it can't be chosen again
            availableSpawnPoints.RemoveAt(randomIndex);
        }
    }
}
