using UnityEngine.UI;
using UnityEngine;

public class GlobalButtonReferences : MonoBehaviour
{
    public static GlobalButtonReferences Instance { get; private set; }

    public Button audioButton;
    public Button controlButton;
    public Button creditButton;
    public Button optionButton;

    private void Awake()
    {
        if (gameObject.CompareTag("PersistentObject"))
        {
            DontDestroyOnLoad(gameObject);
            Debug.Log("ACCESSED");
        }
        else
        {
            Debug.LogWarning("Destroying non-persistent object: " + gameObject.name);
            Destroy(gameObject);
        }
    }
    /*
    // Function to recover button references if null
    public void RecoverButtons()
    {
        if (audioButton == null)
        {
            GameObject audioBtn = GameObject.Find("YourAudioButtonName"); // Find the audio button GameObject
            if (audioBtn != null)
            {
                audioButton = audioBtn.GetComponent<Button>(); // Get the Button component
            }
        }
        // Repeat for other buttons (controlButton, creditButton, etc.)
    }*/
}
