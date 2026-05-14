using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles1 : MonoBehaviour
{
    public GameObject obstacle1;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    //I'm setting this to true to indicate that the initial delay has passed
    private bool initialDelayPassed = false;

    //I'm calling the start function 
    void Start()
    {
        //I'm setting the initial spawn time to the current time plus 1.3 seconds
        spawnTime = Time.time + 1.3f;
    }

    //I'm calling the updation function
    void Update()
    {
        //I'm checking if the initial delay has passed
        if (Time.time > spawnTime && initialDelayPassed)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        else
        {
            //I'm making the condition that if the initial delay has not passed, check if it has now passed
            if (Time.time > spawnTime)
            {
                initialDelayPassed = true;
            }
        }
    }

    //I'm calling the spawn function
    void Spawn()
    {
        //I'm determing the location in which the obstacle game object will spawn
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle1, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
