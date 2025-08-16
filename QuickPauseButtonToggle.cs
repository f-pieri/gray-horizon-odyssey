using UnityEngine;
using UnityEngine.UI;

public class QuickPauseButtonToggle : MonoBehaviour
{
    public Button pauseButton; // Reference to your pause button UI component

    void Start()
    {
        Invoke(nameof(SimulateButtonClick), 0.1f); // Trigger the button click after a 0.1 second delay
    }

    void SimulateButtonClick()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.Invoke(); // Programmatically invoke the button's onClick event
        }
    }
}
