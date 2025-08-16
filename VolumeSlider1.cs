using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider1 : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    private AudioSource backgroundMusicAudioSource;
    private const string musicVolumeKey = "musicVolume";

    private void Start()
    {
        backgroundMusicAudioSource = FindObjectOfType<AudioSource>(); // Adjust this based on how you're managing your music

        if (PlayerPrefs.HasKey(musicVolumeKey))
        {
            volumeSlider.value = PlayerPrefs.GetFloat(musicVolumeKey);
            UpdateBackgroundMusicVolume();
        }
    }

    public void ChangeVolume()
    {
        if (backgroundMusicAudioSource != null)
        {
            backgroundMusicAudioSource.volume = volumeSlider.value;
            SaveVolume();
        }
    }

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat(musicVolumeKey, volumeSlider.value);
    }

    private void UpdateBackgroundMusicVolume()
    {
        if (backgroundMusicAudioSource != null)
        {
            backgroundMusicAudioSource.volume = volumeSlider.value;
        }
    }
}
