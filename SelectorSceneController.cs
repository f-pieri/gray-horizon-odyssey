using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorSceneController : MonoBehaviour
{
    private BackgroundMusic1 backgroundMusic;
    private BackgroundMusic1 sampleSceneMusic; // Reference to the music from the sample scene

    private void Start()
    {
        backgroundMusic = FindObjectOfType<BackgroundMusic1>();

        // Check if BackgroundMusic1 exists
        if (backgroundMusic != null)
        {
            // Find the music from the sample scene
            GameObject sampleSceneMusicObject = GameObject.Find("BackgroundMusicObjectNameInSampleScene"); // Replace with the actual name
            if (sampleSceneMusicObject != null)
            {
                sampleSceneMusic = sampleSceneMusicObject.GetComponent<BackgroundMusic1>();
                if (sampleSceneMusic != null)
                {
                    // Stop the music from the sample scene
                    sampleSceneMusic.StopMusic();
                }
            }

            // Continue handling the music in the selector scene
            // For example, if you want to unpause the music when entering the scene:
            backgroundMusic.UnpauseMusic();
        }
    }
}
