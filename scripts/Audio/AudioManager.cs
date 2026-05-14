using UnityEngine;

public class AudioManager : MonoBehaviour
{
    void Awake()
    {
        AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // Disable all Audio Listeners except the first one
        for (int i = 1; i < audioListeners.Length; i++)
        {
            audioListeners[i].enabled = false;
        }
    }
}
