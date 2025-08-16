using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private float normalSpeed = 5.0f;
    private float pausedSpeed = 0.0f;

    private bool isPaused = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (!isPaused)
        {
            Vector3 move = transform.right * normalSpeed * Time.deltaTime;
            controller.Move(move);
        }
    }

    public void PausePlayer()
    {
        isPaused = true;
        pausedSpeed = normalSpeed;
        normalSpeed = 0.0f;
    }

    public void ResumePlayer()
    {
        isPaused = false;
        normalSpeed = pausedSpeed;
    }
}
