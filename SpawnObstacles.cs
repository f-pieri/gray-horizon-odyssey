using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
	public GameObject obstacle;
	public float maxX; 
	public float minX; 
	public float maxY;
	public float minY; 
	public float timeBetweenSpawn;
	private float spawnTime; 
    
    //I'm calling the update function
    void Update()
    {
		//I'm determing the time it will take for the obstacle game object to spawn
       	if(Time.time > spawnTime)
		{ 
			Spawn(); 
			spawnTime = Time.time + timeBetweenSpawn;
        }
	 }

	//I'm calling the spawn function
	void Spawn()
	{
		//I'm determing the location in which the obstacle game object will spawn
		float randomX = Random.Range(minX, maxX); 
		float randomY = Random.Range(minY, maxY);

		Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
	 }
}
