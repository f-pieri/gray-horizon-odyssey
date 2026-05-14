using UnityEngine;
using UnityEngine.UI;

public class AAA : MonoBehaviour
{
    public GameObject objectToDeactivate;

    void Start()
    {
        // Ensure the object to deactivate is not null
        if (objectToDeactivate == null)
        {
            Debug.LogWarning("No object to deactivate assigned!");
        }

        Button button = GetComponent<Button>();
        if (button != null)
        {
            // Subscribe to the button's onClick event
            button.onClick.AddListener(DeactivateGameObject);
        }
        else
        {
            Debug.LogWarning("Button component not found!");
        }
    }

    public void DeactivateGameObject()
    {
        // Deactivate the assigned GameObject
        if (objectToDeactivate != null)
        {
            objectToDeactivate.SetActive(false);
        }
    }
}
