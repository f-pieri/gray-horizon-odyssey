using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemManager : MonoBehaviour
{
    private static EventSystemManager instance;

    void Awake()
    {
        // Check if an instance already exists
        if (instance != null)
        {
            // If an instance already exists, destroy this one
            Destroy(gameObject);
            return;
        }

        // Set this as the singleton instance
        instance = this;

        // Ensure this object persists across scenes
        DontDestroyOnLoad(gameObject);

        // Check if there's no EventSystem in the scene
        if (FindObjectOfType<EventSystem>() == null)
        {
            // Create and configure a new EventSystem object
            GameObject eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>(); // Add an input module as needed
            DontDestroyOnLoad(eventSystem);
        }
    }
}
