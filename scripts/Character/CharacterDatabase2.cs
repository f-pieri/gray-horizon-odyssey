using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase2 : ScriptableObject
{
    public Character2[] character2;

    public int CharacterCount
    {
        get
        {
            return character2.Length;
        }
    }

    public Character2 GetCharacter(int index)
    {
        return character2[index];
    }
}
