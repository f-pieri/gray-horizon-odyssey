using UnityEngine;
using UnityEngine.UI;

public class RestartButtonHandler : MonoBehaviour
{
    public GameObject holder;
    public AAA aaaScript;

    void Start()
    {
        // Ensure the AAA script and holder object are assigned
        if (aaaScript == null || holder == null)
        {
            Debug.LogWarning("AAA script or holder object not assigned!");
            return;
        }

        Button restartButton = GetComponent<Button>();
        if (restartButton != null)
        {
            // Subscribe to the button's onClick event
            restartButton.onClick.AddListener(ActivateAAAAndDeactivateHolder);
        }
        else
        {
            Debug.LogWarning("Button component not found!");
        }
    }

    void ActivateAAAAndDeactivateHolder()
    {
        // Trigger AAA script to deactivate the holder GameObject
        aaaScript.DeactivateGameObject();
    }
}
