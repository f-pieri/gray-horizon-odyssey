using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider2 : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    public AudioSource soundPlayer1; // Adjust this based on your sound effect management

    private void Start()
    {
        if (PlayerPrefs.HasKey("ButtonVolume"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("ButtonVolume");
            UpdateSoundEffectVolume();
        }
    }

    public void ChangeVolume()
    {
        if (soundPlayer1 != null)
        {
            soundPlayer1.volume = volumeSlider.value;
            SaveVolume();
            GlobalVolume.ButtonVolume = volumeSlider.value; // Update the global volume variable
        }
    }

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("ButtonVolume", volumeSlider.value);
        PlayerPrefs.Save();
    }

    private void UpdateSoundEffectVolume()
    {
        if (soundPlayer1 != null)
        {
            soundPlayer1.volume = volumeSlider.value;
        }
    }
}
