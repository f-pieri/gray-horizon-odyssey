using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public void OnPlayButtonClicked()
    {
        int selectedCharacterIndex = PlayerPrefs.GetInt("selectedOption", 0);
        Debug.Log(selectedCharacterIndex);

        if (characterDB != null && selectedCharacterIndex >= 0 && selectedCharacterIndex < characterDB.CharacterCount)
        {
            Character selectedCharacter = characterDB.GetCharacter(selectedCharacterIndex);

            int slotIndex = FindCharacterSlotIndex(selectedCharacter);

            PlayerPrefs.SetInt("SelectedCharacterIndex", slotIndex);
            PlayerPrefs.Save();

            Debug.Log("Selected Character Index: " + slotIndex);
            //SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Debug.LogError("Character database or selected character not found!");
        }
    }

    int FindCharacterSlotIndex(Character character)
    {
        for (int i = 0; i < characterDB.CharacterCount; i++)
        {
            if (characterDB.GetCharacter(i) == character)
            {
                return i; // Return the slot index where the character is found
            }
        }
        return -1;
    }
}
