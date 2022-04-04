using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskSpawner : MonoBehaviour
{

    public float flaskSpawnCountdown = 5f;
    public float initialCountdown = 20f;

    public Transform[] flaskSpawnpoints;

    public Transform flask;

    // Update is called once per frame
    void Update()
    {

        flaskSpawnCountdown -= Time.deltaTime;

        if (flaskSpawnCountdown <= 0)
        {
            SpawnFlask(flask);
            flaskSpawnCountdown = initialCountdown;
        }

    }

    public void SpawnFlask (Transform flask)
    {
        Transform _sp = flaskSpawnpoints[Random.Range(0, flaskSpawnpoints.Length)];
        Instantiate(flask, _sp.position, _sp.rotation);
    }
}
