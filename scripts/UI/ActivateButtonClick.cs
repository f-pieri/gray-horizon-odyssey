using UnityEngine;

public class ActivateButtonClick : MonoBehaviour
{
    public GameObject menu; // Reference to the entire menu object

    void Start()
    {
        // Hide the entire menu on Start
        menu.SetActive(false);
    }

    public void ToggleMenuVisibility()
    {
        // Toggle visibility of the entire menu when the button is clicked
        menu.SetActive(!menu.activeSelf);
    }
}
