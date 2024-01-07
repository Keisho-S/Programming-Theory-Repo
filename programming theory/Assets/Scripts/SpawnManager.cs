using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject powerup;

    private float SpawnXbound = 15;
    private float enemySpawnZbound = 9;
    private float spawnYbound = 0.75f;

    private float powerupSpawnZbound = 3;

    float startDelay = 1;
    float enemyRepeatRate = 2;
    float powerupRepeatRate = 4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemyRepeatRate);
        InvokeRepeating("SpawnRandomPowerup",startDelay, powerupRepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        float randomEnemyPosX = Random.Range(SpawnXbound, -SpawnXbound);
        Vector3 randomSpawnPos = new Vector3(randomEnemyPosX, spawnYbound, enemySpawnZbound);
        int randomEnemyIndex = Random.Range(0, enemy.Length);

        Instantiate(enemy[randomEnemyIndex], randomSpawnPos, enemy[randomEnemyIndex].transform.rotation);
    }

    void SpawnRandomPowerup()
    {
        float randomPosX = Random.Range(SpawnXbound, -SpawnXbound);
        float randomPosZ = Random.Range(powerupSpawnZbound, -powerupSpawnZbound);
        Vector3 randomSpawnPos = new Vector3(randomPosX, spawnYbound, randomPosZ);

        Instantiate(powerup, randomSpawnPos,powerup.transform.rotation);
    }
}
