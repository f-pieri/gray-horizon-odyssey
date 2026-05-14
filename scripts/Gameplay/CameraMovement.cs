using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private bool canMoveCamera = true;
    private float cameraSpeed = 15f; //I'm setting the initial camera speed

    //I'm calling the update function
    void Update()
    {
        if (canMoveCamera)
        {
            //I'm allowing for camera movement 
            transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        }
    }

    public void StopCamera()
    {
        //I'm making a condition for when not to move camera
        canMoveCamera = false;
    }

    public void ResumeCamera()
    {
        //I'm making a condition for when to move camera
        canMoveCamera = true;
    }
}
