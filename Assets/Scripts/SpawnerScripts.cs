using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScripts : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Shield;
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 3f;
    public float minShieldSpawnInterval = 15f;
    public float maxShieldSpawnInterval = 20f;
    public GameObject targetObject;


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
        if (targetObject != null)
        {
            Instantiate(Shield, transform.position, targetObject.transform.rotation);
        }

        NextShieldSpawn();
    }
}
