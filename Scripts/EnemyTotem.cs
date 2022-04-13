using UnityEngine;
using System.Collections;

public class EnemyTotem : MonoBehaviour
{
    [SerializeField] private float spawnCountdown = 4f;

    public Transform spawnPoint;
    public GameObject enemyPrefab;
   
    private void Start ()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy ()
    {
        while (this.enabled)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(spawnCountdown);
        }
    }

}
