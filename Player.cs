using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public GameObject gameOverPanel;
    public GameObject[] playerCharacters; // Array to hold all player character GameObjects
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOverPanel.SetActive(false);

        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            selectedOption = PlayerPrefs.GetInt("selectedOption");
        }

        UpdateCharacter(selectedOption);

        // Load the character from the NewCharacterDatabase2 based on the selected index
        CharacterDatabase2 characterDatabase = Resources.Load<CharacterDatabase2>("NewCharacterDatabase2");
        // ... rest of your previous logic for enabling/disabling player characters ...
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    int GetCharacterIndex(string characterName)
    {
        for (int i = 0; i < playerCharacters.Length; i++)
        {
            if (playerCharacters[i].name == characterName)
            {
                return i;
            }
        }
        return -1;
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;

        if (playerCharacters == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
