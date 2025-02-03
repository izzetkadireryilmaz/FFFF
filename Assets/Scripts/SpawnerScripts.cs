using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScripts : MonoBehaviour
{
    public GameObject Bullet, Shield, ShieldZeppelin, targetObject;
    public float minSpawnInterval = 1f, maxSpawnInterval = 3f, minShieldSpawnInterval = 20f, maxShieldSpawnInterval = 35f;


    void Start()
    {
        NextSpawn();
        NextShieldSpawn();
    }

    void NextSpawn()
    {
        float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnBullet", spawnInterval);
    }

    void SpawnBullet()
    {
        if (targetObject != null)
        {
            Instantiate(Bullet, transform.position, targetObject.transform.rotation);
        }

        NextSpawn();
    }

    void NextShieldSpawn()
    {
        float spawnShieldInterval = Random.Range(minShieldSpawnInterval, maxShieldSpawnInterval);
        Invoke("SpawnShield", spawnShieldInterval);
    }

    void SpawnShield()
    {
        if (targetObject != null && !ShieldZeppelin.activeSelf)
        {
            Instantiate(Shield, transform.position, targetObject.transform.rotation);
        }

        NextShieldSpawn();
    }
}
