using UnityEngine;

public static class GlobalVolume1
{
    private static float buttonVolume;

    public static float GetVolume()
    {
        return buttonVolume;
    }

    public static void SetVolume(float volume)
    {
        buttonVolume = volume;
        // Save the volume to PlayerPrefs or other storage here if needed
        PlayerPrefs.SetFloat("ButtonVolume", buttonVolume);
        PlayerPrefs.Save(); // Save changes
    }
}
