using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTotem : MonoBehaviour
{
    public float spawnCountdown = 4f;
    public float initialSpawnCountdown = 4f;

    public Transform spawnPoint;

    public GameObject enemyPrefab;
   
    // Update is called once per frame
    void Update()
    {
        spawnCountdown -= Time.deltaTime;

        if (spawnCountdown <= 0)
        {
            SpawnEnemy();
            spawnCountdown = initialSpawnCountdown;
        }
    }

    public void SpawnEnemy ()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
