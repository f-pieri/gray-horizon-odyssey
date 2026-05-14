using UnityEngine;
using UnityEngine.UI;

public class TaggedBoolScript : MonoBehaviour
{
    public static bool taggedBool = false; // Declaring boolean variable as false initially

    public Button audioButton; // Reference to the Audio Button
    public Button controlButton; // Reference to the Control Button
    public Button creditButton; // Reference to the Credit Button
    public Button optionButton; // Reference to the Option Button

    private bool sceneLoaded = false;

    void Start()
    {
        int sceneLoadedValue = PlayerPrefs.GetInt("SceneLoaded", 0);

        if (sceneLoadedValue == 0)
        {
            sceneLoaded = true;
            PlayerPrefs.SetInt("SceneLoaded", 2); // Set the sceneLoaded flag to 1 to indicate scene has been loaded once
            PlayerPrefs.Save();
        }
    }

    void Update()
    {
        // Checking if taggedBool is true and scene is loaded for the first time
        if (taggedBool && sceneLoaded)
        {
            // Setting interactability of buttons to true
            audioButton.interactable = true;
            controlButton.interactable = true;
            creditButton.interactable = true;
            optionButton.interactable = true;
        }
    }
}
