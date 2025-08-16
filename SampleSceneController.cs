using UnityEngine;

public class SampleSceneController : MonoBehaviour
{
    public GameObject[] playerCharacters;

    void Start()
    {
        int selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacterIndex", 0);

        // Disable characters that are not the selected character
        for (int i = 0; i < playerCharacters.Length; i++)
        {
            // Compare the character index in the object name
            int characterIndexInName = int.Parse(playerCharacters[i].name);

            if (characterIndexInName != selectedCharacterIndex)
            {
                playerCharacters[i].SetActive(false);
            }
        }
    }
}
