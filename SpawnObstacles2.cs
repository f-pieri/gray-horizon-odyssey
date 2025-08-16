using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles2 : MonoBehaviour
{
    public GameObject obstacle2;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    //I'm declaring the start function 
    void Start()
    {
        //I'm setting initial spawn time to the current time
        spawnTime = Time.time;
    }

    //I'm calling the update function
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    //I'm calling the spawn method
    void Spawn()
    {
        //I'm determing the location in which the obstacle game object will spawn
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle2, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
