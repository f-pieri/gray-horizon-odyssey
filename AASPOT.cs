using UnityEngine;
using UnityEngine.UI;

public class AASPOT : MonoBehaviour
{
    private Button parentButton;

    void Start()
    {
        gameObject.SetActive(false); // Disable the child button on Start

        // Find the parent button
        parentButton = transform.parent.GetComponent<Button>();

        if (parentButton != null)
        {
            // Subscribe to the parent button's onClick event
            parentButton.onClick.AddListener(EnableChildButton);
        }
        else
        {
            Debug.LogWarning("Parent button not found!");
        }
    }

    void EnableChildButton()
    {
        gameObject.SetActive(true); // Enable the child button when the parent is clicked
    }
}
