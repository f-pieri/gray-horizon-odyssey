using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    private bool isGameOver = false;

    //I'm calling the stopbackgroundlooping function
    public void StopBackgroundLooping()
    {
        isGameOver = true;
    }

    //I'm calling the update function
    void Update()
    {
        //I'm referencing an if statement with a condition
        if (!isGameOver)
        {
            //I'm creating the condition for my looping background
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        }
    }
}
