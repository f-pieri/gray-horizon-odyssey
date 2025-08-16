using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
	private GameObject player;
	public int scoreValue = 10;

	//I'm calling the start function
	void Start()
	{
		//I'm finding the game object labeled with the player tag when the game launches
		player = GameObject.FindGameObjectWithTag("Player");
	}

	//Calling the ontriggerenter2d function 
	private void OnTriggerEnter2D(Collider2D collision)
	{
		//I'm destroying the obstacle game objects if it hits my vertical border at the back
		if (collision.tag == "Border")
		{
			Destroy(this.gameObject);
		}

		//I'm destroying the player spriteif it it hits an obstacle game object
		else if (collision.tag == "Player")
		{
			GlobalSubstance.obstacleTriggered = true;
			Destroy(player.gameObject);
		}
	}
}
