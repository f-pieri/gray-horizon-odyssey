using UnityEngine;
using UnityEngine.UI;

public class VolumeInitializer : MonoBehaviour
{
    [SerializeField] Slider musicVolumeSlider;
    [SerializeField] Slider soundEffectVolumeSlider;

    private void Start()
    {
        InitializeVolumeSliders();
    }

    private void InitializeVolumeSliders()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            float savedMusicVolume = PlayerPrefs.GetFloat("musicVolume");
            musicVolumeSlider.value = savedMusicVolume;
            UpdateBackgroundMusicVolume(savedMusicVolume);
        }

        if (PlayerPrefs.HasKey("soundEffectVolume"))
        {
            float savedSoundEffectVolume = PlayerPrefs.GetFloat("soundEffectVolume");
            soundEffectVolumeSlider.value = savedSoundEffectVolume;
            UpdateSoundEffectVolume(savedSoundEffectVolume);
        }
    }

    private void UpdateBackgroundMusicVolume(float volume)
    {
        BackgroundMusic1 backgroundMusic = FindObjectOfType<BackgroundMusic1>();
        if (backgroundMusic != null)
        {
            backgroundMusic.GetComponent<AudioSource>().volume = volume;
        }
    }

    private void UpdateSoundEffectVolume(float volume)
    {
        //Update sound effect volume using the retrieved volume value
        //Assuming you have a script managing sound effects similarly to the music
    }
}
