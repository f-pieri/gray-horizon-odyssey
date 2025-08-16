# Gray Horizon Odyssey
#### Video Demo: https://youtu.be/tbmjVBqXAr0 

Built a C# Unity game running on Itch.io. This game was created to address the critical issue of water pollution in an engaging and inclusive manner suitable for all ages. 

Within the game, players have the freedom to personalize their audio experience, choose their preferred boat, and navigate it skillfully to evade the floating debris in the waterways!

UN Sustainable Development Goal 6: Clean water and sanitation. 

Within the modern world, bodies of water alike are becoming more polluted by the year. Water pollution remains less obvious than other forms of pollution, like air pollution. 

What is water pollution? Water pollution occurs when harmful substances—often chemicals or micro-organisms—contaminate a stream, river, lake, ocean, or other body of water, degrading water quality and rendering it toxic to humans or the environment. 

47% of Americans aren't aware of water pollution. Let's become informed and take action! 
# Script 1 - AAA: Deactivate GameObject on Button Click
This Unity script deactivates a specified GameObject when the attached button is clicked. Make sure to assign the target GameObject in the objectToDeactivate field. If the button or GameObject isn't set, a warning will appear in the console.

# Script 2 - AASPOT: Enable Child Button on Parent Button Click
This Unity script disables a child button on start and re-enables it when the parent button is clicked. It automatically finds the parent button and subscribes to its onClick event. If the parent button isn't found, a warning is logged.

# Script 3 - ActivateButtonClick: Toggle Menu Visibility
This Unity script hides a menu on start and toggles its visibility when a button is clicked. The script references the entire menu object and switches its active state on each button click.

# Script 4 - AudioManager: Manage Audio Listeners
This Unity script disables all but the first AudioListener in the scene to prevent multiple audio sources from playing simultaneously. It automatically detects and disables additional listeners during the Awake phase.

# Script 5 - BackArrowButton1: Toggle UI Buttons and Child Elements
This Unity script toggles the visibility of child elements for multiple UI buttons when the back arrow button is clicked. It checks for references to global UI buttons, flips their visibility, and ensures they remain interactable. Additionally, the script manages a flipSwitch to track the toggle state.

# Script 6 - BackArrowButton2: Toggle UI Buttons with Child Elements
This Unity script toggles the visibility of all child GameObjects within specified UI buttons (Audio, Control, Credit, Option) when the back arrow button is clicked. It also updates the flipSwitch variable to track the toggle state and ensures that all buttons remain interactable.

# Script 7 - BackArrowButton3: Toggle UI Buttons with Child Elements
This Unity script toggles the visibility of all child GameObjects within specified UI buttons (Audio, Control, Credit, Option) when the back arrow button is clicked. It also updates the flipSwitch variable to track the toggle state and ensures that all buttons remain interactable.

# Script 8 - BackArrowButton4: Toggle UI Buttons and Manage Visibility
This Unity script manages the visibility of child GameObjects within specified UI buttons (Audio, Control, Credit, Option) when the back arrow button is clicked. It toggles the flipSwitch variable to track state changes and ensures all buttons remain interactable.

# Script 9 - BackgroundMusic: Manage Background Music Across Scenes
This Unity script handles background music management, ensuring that music persists across scenes and is appropriately played, paused, or stopped based on the scene index. It includes functionality to mute/unmute the audio and control playback state.

Singleton Pattern: Maintains a single instance of the background music across scenes using DontDestroyOnLoad.

Scene Management: Stops music in specific scenes (index 0 and 2) and plays it in others.

Playback Controls: Includes methods to play, pause, unpause, stop, and restart music.

Mute Functionality: Allows toggling the mute state and checks if the music is currently muted.

# Script 10 - BackgroundMusic1: Advanced Background Music Management
This Unity script manages background music with additional scene-specific controls and enhanced mute functionality. It ensures that music persists across scenes, handles playback based on scene conditions, and provides methods to control music playback and mute state.

Singleton Pattern: Maintains a single instance of the background music object using DontDestroyOnLoad.

Scene Management: Pauses, unpauses, or restarts music depending on the scene index or name (e.g., resets music when entering the "HomeScene").

Playback Controls: Includes methods to play, pause, unpause, stop, and restart music with checks for mute state.

Mute Functionality: Toggles mute state and provides status checks for whether music is muted.

# Script 11 - ButtonSound: Manage Sound Effects for Buttons
This Unity script handles playing sound effects when a button is interacted with. It uses an AudioSource to play sounds and tracks whether the sound has been triggered using the soundTriggered variable.

Sound Playback: Plays a sound effect if GlobalVariables.Checkmark is true.

Sound Tracking: Updates the soundTriggered variable to track if the sound has been triggered.

Debugging: Provides debug logs to track the state of sound playback.

# Script 12 - ButtonSound2: Control Sound Effects with Additional Checks
This Unity script manages sound effects for button interactions, using an AudioSource to play sounds. It includes a soundTriggered1 variable to track if the sound has been triggered and checks a global variable to determine if the sound should play.

Sound Playback: Plays a sound effect if GlobalVariables1.newCheckmark is true.

Sound Tracking: Monitors the playback state of the sound with soundTriggered1.

Debugging: Logs messages to indicate if the sound is still playing or has been stopped.

# Script 13 - ButtonSoundPlayer: Play Button Click Sound
This Unity script plays a button click sound using an AudioSource component. The AudioClip for the button click sound is assigned through the Inspector.

Sound Playback: Plays the assigned buttonClickSound when the PlayButtonClickSound method is called.

Setup: Retrieves the AudioSource component at the start to handle playback.

# Script 14 - CameraMovement: Control Camera Movement
This Unity script controls the movement of the camera along the x-axis. It allows for camera movement with a set speed and provides methods to start or stop the movement.

Camera Movement: Moves the camera along the x-axis based on cameraSpeed when canMoveCamera is true.

Control Methods: StopCamera and ResumeCamera methods toggle the ability to move the camera.

# Script 15 - CandleStickControl: Play Sound Based on Condition
This Unity script plays a sound using an AudioSource when a specific condition from SoundManager4 is met. It checks if SoundManager4.candleStick is true and plays the sound accordingly.

Condition Check: Plays the sound if SoundManager4.candleStick is true.

Sound Playback: Uses soundPlayer1 to handle the audio playback.

# Script 16 - ChangeScene: Switch to a Specified Scene
This Unity script handles scene transitions, loading a specified scene when the MoveToHomeMenu method is called.

Scene Loading: Loads the scene specified by the sceneToLoad variable.

Debugging: Logs messages indicating the scene has been switched and loaded.

# Script 17 - ChangeScene2: Load Selector Scene
This Unity script switches to the "Selector" scene when the MoveToSelector method is called.

Scene Transition: Loads the "Selector" scene, replacing the current scene using LoadSceneMode.Single.

# Script 18 - Character: Define Character Attributes
This Unity script defines a Character class with a serializable attribute for character customization.

Character Attributes: Contains a public Sprite field named characterSprite to hold the character's visual representation.

# Script 19 - Character2: Define Character Names
This Unity script defines a Character2 class with a serializable attribute for identifying character names.

Character Attributes: Contains a public string field named characterGameObjectName for specifying the character's name.

# Script 20 - CharacterDatabase: Manage Character Data
This Unity script defines a CharacterDatabase as a ScriptableObject to manage an array of Character objects.

Character Array: Stores a list of Character objects.

Character Count: Provides a property to get the number of characters.

Get Character: Retrieves a specific Character by index.

# Script 21 - CharacterDatabase2: Manage Character2 Data
This Unity script defines a CharacterDatabase2 as a ScriptableObject to manage an array of Character2 objects.

Character2 Array: Stores a list of Character2 objects.

Character Count: Provides a property to get the number of Character2 items.

Get Character: Retrieves a specific Character2 by index.

# Script 22 - CharacterManager: Handle Character Selection and Display
This Unity script manages character selection and display, allowing users to cycle through characters and persist their choice.

Character Selection: Uses CharacterDatabase to manage and display character options.

Option Navigation: Includes methods NextOption and BackOption to navigate through available characters.

Persistence: Saves and loads the selected character option using PlayerPrefs.

# Script 23 - CharacterSelector: Select and Save Character Index
This Unity script handles the selection and saving of a character index when the play button is clicked.

Character Selection: Retrieves the currently selected character from PlayerPrefs.

Slot Index Finding: Determines the index of the selected character within the CharacterDatabase.

Persistence: Saves the selected character's slot index to PlayerPrefs.

# Script 24 - EventSystemManager: Singleton for EventSystem Management
This Unity script ensures that an EventSystem exists in the scene and is managed as a singleton.

Singleton Pattern: Ensures only one instance of EventSystemManager exists.

EventSystem Creation: Creates and configures an EventSystem if none exists in the scene.

Persistence: Makes sure the EventSystemManager persists across scene loads.

# Script 25 - GameOver: Manages Game Over State
This Unity script handles the game-over state by managing UI, game mechanics, and background music.

Game Over Actions:
  Displays gameOverPanel. | 
  Stops background looping and particle effects. | 
  Pauses the camera movement. | 
  Pauses background music and updates high score.

Restart Functionality: Resets obstacleTriggered and reloads the current scene. | Resumes camera movement and unpauses background music.

References: Links to LoopingBackground, StopParticlesOnGameOver, CameraMovement, BackgroundMusic, HighScoreManager, and ScoreManager.

# Script 26 - GlobalButtonReferences: Manages Persistent Button References
This Unity script handles global references to UI buttons and ensures persistence across scenes.

Instance: Provides a global access point to the GlobalButtonReferences instance.

Button References: audioButton, controlButton, creditButton, optionButton: Public fields to assign button references in the Inspector.

Persistence: The Awake method checks if the object has the "PersistentObject" tag to prevent destruction across scene loads.

Button Recovery (Commented Out):
The RecoverButtons function is intended to find and assign button references if they are null. (Commented out in the current script.)

# Script 27 - GlobalSubstance: Global State Management
This static class maintains global state for the obstacleTriggered flag.

Purpose: Provides a global, static variable to track if an obstacle has been triggered.

Static Field: obstacleTriggered- A public static boolean that other scripts can access and modify.

# Script 28 - GlobalVolume: Volume Management
This static class manages global volume settings for button sounds.

Purpose: Provides a global static property to access and modify button volume levels.

Static Property: ButtonVolume- A public static float property that stores the volume level for button sounds.

# Script 29 - GlobalVolume1: Enhanced Volume Management
This static class manages button volume with additional functionality.

Purpose: Provides global access to button volume settings with encapsulation and storage.

Private Field: buttonVolume- A private static float that stores the button volume level.

Public Static Methods: GetVolume()- Returns the current button volume level. | SetVolume(float volume)- Sets the button volume level and saves it using PlayerPrefs.

Additional Features: The SetVolume method saves the volume level to PlayerPrefs, making it persistent across sessions.

# Script 30 - HighScoreManager: Managing and Displaying High Scores
This script manages and displays the high score for a game, using Unity's PlayerPrefs for persistent storage.

Purpose: Tracks the highest score achieved and updates the UI text accordingly.

Public Fields: highScoreText- Reference to the UI Text component that displays the high score.

Private Fields: highScore- Stores the current high score. | scoreManager- Reference to the ScoreManager script.

Start Method: Initializes highScore from PlayerPrefs. | Updates the high score display. | Finds and references the ScoreManager script.

Public Methods: UpdateHighScore(float currentScore)- Updates the high score if the current score exceeds it and saves the new high score to PlayerPrefs.

Private Methods: UpdateHighScoreText()- Formats and updates the high score text to a 5-digit string.

# Script 31 - HomeSwitch: Handling Transitions to the Home Screen
This script manages transitions to the home screen, stopping background elements and updating the high score when certain conditions are met.

Purpose: Handles the transition and management of game elements when an obstacle is triggered.

Public Fields: homeButton- Reference to the UI Button for returning to the home screen.

Private Fields:
loopingBackground- Reference to the LoopingBackground script. | 
cameraMovement- Reference to the CameraMovement script. | 
highScoreManager- Reference to the HighScoreManager script. | 
scoreManager- Reference to the ScoreManager script.

Start Method:
Initializes references to LoopingBackground, CameraMovement, HighScoreManager, and ScoreManager scripts.

Update Method:
Checks if GlobalSubstance.obstacleTriggered is true. | 
Stops background looping. | 
Stops the camera movement. | 
Updates the high score based on the current score.

Public Methods:
Restart()- Intended to reset the state (currently commented out).

Script 32 - LoadHomeMenu: Loading the Home Menu Scene
This script provides functionality to load the "HomeMenu" scene when triggered.

Purpose: Loads the "HomeMenu" scene.

Public Methods: LoadSceneHomeMenu()- Uses SceneManager.LoadScene to load the "HomeMenu" scene.

# Script 33 - LoopingBackground: Handling Background Scrolling
This script controls the movement of a looping background texture and stops the scrolling when the game is over.

Purpose: Manages the scrolling of a background texture and stops it when the game ends.

Public Variables:
backgroundSpeed- Speed at which the background texture scrolls. | 
backgroundRenderer- Renderer component used to apply the texture.

Private Variables:
isGameOver- Flag indicating whether the game is over.

Public Methods:
StopBackgroundLooping()- Sets isGameOver to true, stopping the background movement.

Private Methods:
Update()- Continuously adjusts the mainTextureOffset of the background material to create a scrolling effect if isGameOver is false.

# Script 34 - Obstacle: Handling Collision with Player and Border
This script manages interactions between obstacles and other game objects, including the player and border.

Purpose:
Handles the destruction of obstacles upon collision with specific tags and triggers game state changes when colliding with the player.

Public Variables:
scoreValue- Score awarded for an obstacle; currently unused in this script.

Private Variables:
player- Reference to the player game object.

Private Methods:
Start()- Finds and assigns the player game object at the start of the game. | 
OnTriggerEnter2D(Collider2D collision)- Detects collisions with other game objects:

If colliding with "Border": Destroys the obstacle.
If colliding with "Player": Sets GlobalSubstance.obstacleTriggered to true to signal that the player has hit an obstacle, and then destroys the player game object.

# Script 35 - Obstacle2: Handling Collision with Player and Border
This script is similar to the previous Obstacle script and handles interactions between obstacles and other game objects.

Purpose:
Manages collisions between obstacles and other tagged objects, and updates the game state accordingly.

Public Variables:
scoreValue- Represents the score awarded for the obstacle; not currently used in this script.

Private Variables:
player- Reference to the player game object.

Private Methods:
Start()- Finds and assigns the player game object when the game starts. | 
OnTriggerEnter2D(Collider2D collision)- Handles collisions with other game objects:

If colliding with "Border"- Destroys the obstacle. | 
If colliding with "Player"- Sets GlobalSubstance.obstacleTriggered to true to indicate that the player has hit an obstacle, and then destroys the player game object.

# Script 36 - Obstacle3: Collision Management
This script handles interactions between obstacles and other game objects, specifically dealing with player collisions and border interactions.

Purpose:
Manages the behavior of obstacles when they collide with the border or player.

Public Variables:
scoreValue- Represents the score value associated with the obstacle; currently unused in the script.

Private Variables:
player:- Reference to the player game object.

Private Methods:
Start()- Finds the player game object tagged as "Player" when the game starts. | 
OnTriggerEnter2D(Collider2D collision)- Handles collisions:

If colliding with "Border"- Destroys the obstacle game object. | 
If colliding with "Player"- Sets GlobalSubstance.obstacleTriggered to true to indicate that the player has collided with an obstacle and destroys the player game object.

# Script 37 - PauseMenu: Manages Game Pausing and Resuming
This script controls the pause menu functionality, including pausing and resuming the game, and managing background music.

Purpose:
Manages the display of the pause menu, game time scale, and background music during pauses.

Serialized Fields:
pauseMenu- The UI element for the pause menu.

Private Variables:
backgroundMusic- Reference to the BackgroundMusic script to control music playback. | 
gameOverScript- Reference to the GameOver script, which might be used to check or control game-over state. | 
canAccessPauseMenu- Boolean flag indicating whether the pause menu can be accessed.

Private Methods:
Start()- Initializes the game state, sets time scale to normal, hides the pause menu, and finds references to necessary scripts.

Public Methods:
Pause()- Displays the pause menu, stops game time, and pauses the background music if the pause menu is accessible. | 
Resume()- Hides the pause menu, resumes game time, and unpauses the background music. | 
Home(int sceneID)- Loads a specified scene, setting the game time back to normal. | 
SetAccessToPauseMenu(bool state)- Allows or disallows access to the pause menu based on the boolean state.

# Script 38 - PersistentObject: Ensures an Object Persists Across Scenes
This script ensures that a GameObject with this script attached will persist between scene loads.

Purpose:
Keeps the GameObject from being destroyed when a new scene is loaded.

Private Methods:
Awake()- Calls DontDestroyOnLoad on the attached GameObject, preventing it from being destroyed when a new scene is loaded.

# Script 39 - Player: Controls Player Movement and Character Management
This script manages player movement, character selection, and handles game-over scenarios.

Public Variables:
playerSpeed- Speed of the player. | 
gameOverPanel- UI panel shown when the game is over. | 
playerCharacters- Array of player character GameObjects. | 
characterDB- Reference to the CharacterDatabase. | 
artworkSprite- SpriteRenderer to display the selected character.

Private Variables:
rb- Rigidbody2D component for physics-based movement. | 
playerDirection- Direction vector for player movement. | 
selectedOption- Index of the selected character.

Methods:
Start()- Initializes the Rigidbody2D, game-over panel, and sets up the selected character based on PlayerPrefs. | Loads a character database resource.

UpdateCharacter(int selectedOption)- Updates the displayed character sprite based on the selected index.

GetCharacterIndex(string characterName)- Returns the index of the character with the specified name.

Update()- Reads vertical input to set the movement direction and shows the game-over panel if no characters are available.

FixedUpdate()- Applies movement based on the direction vector and speed.

Restart()- Reloads the current scene to restart the game.

# Script 40 - PlayerMovement: Manages Player Movement and Pause State
This script controls player movement and handles pausing and resuming the player’s movement.

Private Variables:
controller- Reference to the CharacterController component. | 
normalSpeed- Movement speed of the player when not paused. | 
pausedSpeed- Movement speed stored when the player is paused. | 
isPaused- Boolean indicating if the player is currently paused. | 

Methods:
Start()- Initializes the CharacterController component. | 
Update()- Moves the player based on normalSpeed if not paused. Movement is in the direction of transform.right. | 
PausePlayer()- Sets isPaused to true, stops movement by setting normalSpeed to 0, and stores the current speed in pausedSpeed. | 
ResumePlayer()- Resumes movement by restoring normalSpeed from pausedSpeed and sets isPaused to false. | 

# Script 41 - QuickPauseButtonToggle: Simulates Button Click for Quick Pause
This script simulates a button click to trigger a pause action shortly after the scene starts.

Public Variables:
pauseButton- Reference to the UI button component that triggers the pause action.

Methods:
Start()- Calls SimulateButtonClick after a 0.1-second delay to simulate a button click. | 
SimulateButtonClick()- Invokes the onClick event of the pauseButton if it is not null.

# Script 42 - Resetter: Scene Reset with Delayed Sound and Music Handling
This script manages scene resetting with sound effects and background music.

Public Variables:
buttonSound- Reference to the ButtonSound script to play sound effects. | 
backgroundMusic- Reference to the BackgroundMusic script to manage music.

Methods:
ResetSceneWithSound()- Initiates the scene reset process by starting the coroutine ResetSceneWithDelay().

ResetSceneWithDelay()- 
Plays a sound effect if buttonSound is not null. | 
Waits for the sound effect to finish playing (15 seconds or adjust as needed). |
Resets and unpauses the background music if backgroundMusic is not null. | 
Reloads the current scene.

# Script 43 - RestartButtonHandler: Handle Button Click to Manage GameObjects
This script handles a button click to activate a script and manage GameObjects.

Public Variables:
holder- The GameObject that will be deactivated. | 
aaaScript- Reference to the AAA script that manages the deactivation.

Methods:
Start()- Checks if aaaScript and holder are assigned; logs a warning if not. | 
Gets the Button component and subscribes to its onClick event to call ActivateAAAAndDeactivateHolder.

ActivateAAAAndDeactivateHolder(): Calls DeactivateGameObject() on aaaScript to handle the deactivation of the holder GameObject.

# Script 44 - SampleSceneController: Manage Active Characters Based on Selection
This script manages which player characters are active based on the saved selection.

Public Variables: playerCharacters- Array of GameObjects representing different player characters.

Methods:
Start()- Retrieves the selected character index from PlayerPrefs (default is 0). | 
Iterates through the playerCharacters array, disabling characters that do not match the selected index. | 
Assumes the name of each character GameObject contains its index as an integer.

# Script 45 - SceneButton: Load Scene on Button Click
This script handles loading a new scene when a button is clicked.

Public Variables:
sceneName- The name of the scene to load.

Private Variables:
button- Reference to the Button component attached to the GameObject.

Methods:

Start()- Retrieves the Button component. | Attaches the LoadSceneOnClick method to the button's click event.

LoadSceneOnClick():
Loads the scene specified by sceneName when the button is clicked.

# Script 46 - SceneLoader: Play Sound and Load Scene
This script plays a sound and then switches to a new scene after a delay.

Public Variables:
soundPlayer1- Reference to the AudioSource used for playing sound. | 
sceneNameToLoad- The name of the scene to load. | 
sceneSwitchDelay- The delay before switching the scene (default is 5 seconds). | 

Methods:
PlaySoundAndSwitchScene()-
Sets the volume of soundPlayer1 based on GlobalVolume.ButtonVolume. | 
Plays the sound and schedules SwitchScene to be called after sceneSwitchDelay seconds. | 
If soundPlayer1 is not assigned, SwitchScene is called immediately.

SwitchScene():
Loads the scene specified by sceneNameToLoad.

# Script 47 - SceneSwitcher: Play Sound and Load Scene
This script manages scene switching with sound effects. It plays a sound, waits for a specified duration, and then switches to a new scene, stopping the sound if necessary.

Public Variables:
soundPlayer1- Reference to the AudioSource used for playing the sound. | 
sceneToLoad- The name of the scene to load. | 
soundDuration- The duration to wait before switching scenes (default is 0.15 seconds).

Methods:
PlaySoundAndSwitchScene()-
Plays the sound if soundPlayer1 is assigned. | 
Schedules KillSoundAndSwitchScene to be called after soundDuration seconds. | 
Logs messages based on whether the sound is playing or not.

KillSoundAndSwitchScene()-
Stops and disables soundPlayer1 if it is still playing. | 
Calls SwitchScene to change to the new scene. | 
Logs messages about the sound status and scene switch.

SwitchScene()-
Loads the scene specified by sceneToLoad. | 
Logs a message indicating the scene switch.

# Script 48 - SceneSwitcher2: Play Sound and Delay Scene Switch
This script handles scene transitions with an optional sound effect and a configurable delay. It plays a sound effect, waits for a specified delay, and then switches to a new scene.

Public Variables:
soundPlayer1- Reference to the AudioSource for playing the sound. | 
sceneToLoad- The name of the scene to be loaded. | 
sceneSwitchDelay- The delay before switching scenes (default is 5 seconds).

Methods:
PlaySoundAndSwitchScene()-
Plays the sound if soundPlayer1 is assigned. | 
Uses Invoke to call SwitchScene after the sceneSwitchDelay. | 
If no sound is assigned, it calls SwitchScene immediately.

SwitchScene()-
Loads the scene specified by sceneToLoad.

# Script 49 - SceneSwitcher2VolumeCopy: Play Sound with Volume Control
This script plays a sound effect with volume controlled by a global variable.

Public Variables:
soundPlayer1- Reference to the AudioSource for playing the sound.

Methods:
PlaySound()-
Sets the volume of soundPlayer1 using GlobalVolume.ButtonVolume. | 
Plays the sound if soundPlayer1 is assigned.

# Script 50 - ScoreManager: Manage and Display Score
This script manages and displays the player's score, including dynamic visibility effects and continuous score increment.

Public Variables:
scoreText- UI Text component to display the score.

Private Variables:
score- Current score value. | 
scoreIncreaseRate- Rate at which the score increases over time. | 
scoreIncreaseAcceleration- Acceleration rate for the score increase. | 
isScoreIncreased- Flag to manage score visibility toggling. | 
scoreIncreaseDuration- Duration for toggling visibility of increased score. | 
scoreIncreaseTimer- Timer to track duration of visibility toggle. | 
isScoreVisible- Flag to manage score text visibility.

Methods:
Start()-
Initializes the score and updates the display.

Update()-
Increases score continuously based on time. | 
Adjusts score increase rate and manages visibility toggling. | 
Resets score if it exceeds 99999. |
Updates score text display.

UpdateScoreText(float currentScore)-
Formats and updates the score text with leading zeros. | 
Ensures score text visibility if score is zero.

GetScore()-
Returns the current score.

# Script 51 - SelectorSceneController: Manage Background Music in Selector Scene
This script manages background music when transitioning to the selector scene, ensuring proper music handling and avoiding conflicts.

Private Variables:
backgroundMusic- Reference to the BackgroundMusic1 script for the current scene. | 
sampleSceneMusic- Reference to the BackgroundMusic1 script from the sample scene.

Methods:
Start()-
Finds the BackgroundMusic1 component for the current scene. | 
Checks if the BackgroundMusic1 component exists. | 
Finds and stops the background music from the sample scene using its GameObject. | 
Unpauses the music for the current selector scene if needed.

# Script 52 - SoundManager: Manage Sound and Mute State
This script handles sound settings and the mute state for the game. It manages the audio volume, saves the mute state, and updates the UI icon based on the current sound state.

Serialized Fields:
soundOnIcon- Image component for the sound on icon. | 
soundOffIcon- Image component for the sound off icon.

Private Variables:
buttonSound- Reference to the AudioSource used for button sounds. | 
muted- Boolean indicating if the sound is muted.

Methods:
Start()-
Initializes the buttonSound reference. | 
Checks and sets the initial mute state from PlayerPrefs. | 
Updates the UI icon based on the current mute state.

OnButtonPress():-
Toggles the mute state. | 
Adjusts the volume of buttonSound based on the mute state. | 
Saves the new mute state to PlayerPrefs. | 
Updates the UI icon. | 

UpdateButtonIcon()-
Updates the visibility of the sound on/off icons based on the mute state. | 

Load()-
Loads the mute state from PlayerPrefs and applies it.

Save()-
Saves the current mute state to PlayerPrefs.

# Script 53 - SoundManager1: Manage Sound and Mute State with Background Music
This script manages sound and mute states, including the background music, and updates UI icons to reflect the current sound state.

Serialized Fields:
soundOnIcon- Image component for the sound on icon. | 
soundOffIcon- Image component for the sound off icon.

Private Variables:
muted1- Boolean indicating if the sound is muted. 

Methods:
Start()-
Loads the mute state from PlayerPrefs. | 
Updates the UI icon based on the current mute state. | 
Finds or creates a BackgroundMusic object and sets its mute state based on muted1. | 

OnButtonPress()-
Toggles the mute state. | 
Saves the new mute state to PlayerPrefs. | 
Updates the UI icon. | 
Finds the BackgroundMusic object and toggles its mute state based on muted1. | 

UpdateButtonIcon()- Updates the visibility of the sound on/off icons based on the mute state. 

Load()- Loads the mute state from PlayerPrefs and applies it.

Save()- Saves the current mute state to PlayerPrefs and ensures the data is saved immediately.\

# Script 54 - SoundManager3: Manage Sound Icons with Global Variables
This script manages sound icons based on a global variable GlobalVariables.Checkmark to toggle between sound on and sound off states.

Serialized Fields:
soundOnIcon- Image component for the sound on icon. | 
soundOffIcon- Image component for the sound off icon.

Methods:
Awake()- Placeholder for future initialization code. Currently commented out.

Start()- Placeholder for future initialization code. Currently empty.

Update()- Placeholder for future update logic. Currently empty.

OnButtonpress()-
Toggles the GlobalVariables.Checkmark value. | 
Updates the button icons based on the new state of GlobalVariables.Checkmark. | 

UpdateButtonIcon()-
Updates the visibility of the sound on/off icons based on the GlobalVariables.Checkmark value. | 
Forcing a UI update with Canvas.ForceUpdateCanvases().

Debug Logs-
Logs changes in icon visibility for debugging purposes.

# Script 55 - SoundManager4: Manage Sound Icons and Global Variables
This script manages sound icons and toggles a global variable candleStick based on the state of GlobalVariables1.newCheckmark. It updates sound icons and logs changes for debugging.

Serialized Fields:
soundOnIcon- Image component for the sound on icon. | 
soundOffIcon- Image component for the sound off icon.

Public Variables:
candleStick- A static boolean variable to indicate whether sound is on or off.

Methods:
Awake()- Placeholder for initialization code. Currently commented out.

Start()- Placeholder for initialization code. Currently empty.

Update()- Placeholder for update logic. Currently empty.

OnButtonpress()-
Toggles the GlobalVariables1.newCheckmark variable. | 
Updates the button icons based on the new state of GlobalVariables1.newCheckmark. 

UpdateButtonIcon()-
Updates the visibility of the sound on/off icons based on the value of GlobalVariables1.newCheckmark. | 
Sets candleStick to false if GlobalVariables1.newCheckmark is true (indicating no sound) and to true otherwise (indicating sound). | 
Forces a UI update with Canvas.ForceUpdateCanvases().

Debug Logs-Logs the changes in icon visibility and candleStick state for debugging purposes.

# Script 56 - SoundManager5: Handle Sound Mute State and Icons
This script manages the sound mute state and updates the UI icons accordingly. It also handles the initialization and toggling of background music.

Serialized Fields:
soundOnIcon- Image component for the sound on icon. | 
soundOffIcon- Image component for the sound off icon.

Private Variables:
muted- Boolean to track if the sound is muted or not.

Methods:
Start()-
Loads the mute state from PlayerPrefs. | 
Updates the button icons based on the loaded state. | 
Finds or creates a BackgroundMusic1 object and sets its mute state.

OnButtonPress()-
Toggles the muted state. | 
Saves the updated mute state to PlayerPrefs. | 
Updates the button icons to reflect the new mute state. | 
Finds the BackgroundMusic1 object and toggles its mute state.

UpdateButtonIcon()-
Updates the visibility of the sound on/off icons based on the muted state.

Load()- 
Loads the mute state from PlayerPrefs and sets the muted variable.

Save()-
Saves the current mute state to PlayerPrefs and calls PlayerPrefs.Save() to ensure immediate saving.

Dependencies:
BackgroundMusic1- Custom script or component that manages background music and has a ToggleMute(bool) method.

# Script 57 - SoundToggle: Manage Sound Activation and Global Variables
This script controls the activation and deactivation of sound-related GameObjects and manages corresponding global variables.

Serialized Fields:
buttonSound- GameObject for the first sound component. | 
newbuttonSound- GameObject for the second sound component.

Methods:
Start()-Ensures that the sound components are initially enabled.

ToggleSound()-
Toggles the active state of buttonSound and newbuttonSound. | 
Updates the respective global variables based on the active state of each GameObject.

EnableSound()-
Enables buttonSound and sets YourNamespace.GlobalVariables.Checkmark to true.

EnableSound1()-
Enables newbuttonSound and sets YourNamespace1.GlobalVariables1.newCheckmark to true.

DisableSound()-
Disables buttonSound and sets YourNamespace.GlobalVariables.Checkmark to false.

DisableSound1()-
Disables newbuttonSound and sets YourNamespace1.GlobalVariables1.newCheckmark to false.

Dependencies:
YourNamespace.GlobalVariables- Static class holding a boolean flag Checkmark.\

YourNamespace1.GlobalVariables1- Static class holding a boolean flag newCheckmark.

Notes:
The script updates global variables based on the activation state of the GameObjects to maintain sound settings across different parts of the application. | 
Ensure that buttonSound and newbuttonSound are properly assigned in the Unity Inspector for this script to function correctly.

# Script 58 - SpawnObstacles: Control Obstacle Spawning
This script handles the periodic spawning of obstacles within a defined 2D space.

Serialized Fields:
obstacle- The GameObject to be instantiated as an obstacle. | 
maxX- Maximum X coordinate for obstacle spawning. | 
minX- Minimum X coordinate for obstacle spawning. | 
maxY- Maximum Y coordinate for obstacle spawning. | 
minY- Minimum Y coordinate for obstacle spawning. | 
timeBetweenSpawn- Time interval between consecutive spawns.

Private Variables:
spawnTime- The next time at which an obstacle will be spawned.

Methods:
Update()-
Checks if the current time exceeds spawnTime. | 
Calls Spawn() if it's time to spawn a new obstacle and updates spawnTime for the next spawn.

Spawn()-
Determines a random position within the defined minX, maxX, minY, and maxY range. | 
Instantiates the obstacle at the computed position relative to the GameObject’s position and rotation.

Notes:
Ensure that obstacle is assigned in the Unity Inspector to define what prefab should be spawned.
Adjust maxX, minX, maxY, and minY to control the area in which obstacles appear.
timeBetweenSpawn controls the frequency of obstacle spawns. Set this value to manage spawn rate.

# Script 59 - SpawnObstacles1: Enhanced Obstacle Spawning with Initial Delay
This script extends obstacle spawning functionality to include an initial delay before the first spawn.

Serialized Fields:
obstacle1- The GameObject to be instantiated as an obstacle. | 
maxX- Maximum X coordinate for obstacle spawning. | 
minX- Minimum X coordinate for obstacle spawning. | 
maxY- Maximum Y coordinate for obstacle spawning. | 
minY- Minimum Y coordinate for obstacle spawning. | 
timeBetweenSpawn- Time interval between consecutive spawns.

Private Variables:
spawnTime- The next time at which an obstacle will be spawned. 

initialDelayPassed- A boolean flag to check if the initial delay period has passed.

Methods:
Start()-
Sets spawnTime to the current time plus an initial delay of 1.3 seconds.

Update()-
Checks if the current time exceeds spawnTime and if the initial delay has passed. | 
Calls Spawn() and updates spawnTime for the next spawn if the conditions are met. | 
Updates initialDelayPassed if the initial delay has been reached.

Spawn():
Determines a random position within the defined minX, maxX, minY, and maxY range. | 
Instantiates the obstacle1 at the computed position relative to the GameObject’s position and rotation.

Notes:
The initial delay ensures that the first obstacle does not spawn immediately when the game starts, providing a buffer period before spawning begins. | 
Adjust the maxX, minX, maxY, and minY values to control the spawn area. | 
The timeBetweenSpawn value controls the frequency of subsequent spawns.

# Script 60 - SpawnObstacles2: Basic Obstacle Spawning
This script manages obstacle spawning in a straightforward manner, without any initial delay.

Serialized Fields:
obstacle2- The GameObject to be instantiated as an obstacle. | 
maxX- Maximum X coordinate for obstacle spawning. 

minX- Minimum X coordinate for obstacle spawning. 

maxY- Maximum Y coordinate for obstacle spawning. 

minY- Minimum Y coordinate for obstacle spawning. 

timeBetweenSpawn- Time interval between consecutive spawns.

Private Variables:
spawnTime- The next time at which an obstacle will be spawned.

Methods:
Start()-
Initializes spawnTime to the current time, ensuring that the first obstacle spawn occurs immediately upon starting the game.

Update()-
Checks if the current time has surpassed spawnTime. |
Calls Spawn() and updates spawnTime for the next spawn.

Spawn()-
Determines a random position within the defined minX, maxX, minY, and maxY range. | 
Instantiates the obstacle2 at the computed position relative to the GameObject’s position and rotation.

Notes:
This script allows for continuous spawning of obstacles without an initial delay, starting immediately when the game begins.
Adjust the maxX, minX, maxY, and minY values to control the spawn area.
The timeBetweenSpawn value controls the frequency of obstacle spawns.

# Script 61 - StopParticlesOnGameOver: Particle System Management
This script is designed to stop and clear all particle systems associated with a GameObject when a game over condition is met.

Private Variables:
particleSystems- Array holding references to all ParticleSystem components attached to the GameObject or its children.
Methods:

Start()-
Initializes particleSystems by finding and storing all ParticleSystem components attached to the GameObject or its children.\

StopParticles()-
Iterates through each ParticleSystem in particleSystems. | 
Stops emission and clears all existing particles using StopEmittingAndClear, which halts new particles from being emitted and clears the current particles.

Notes:
Attach this script to a GameObject containing particle systems that you want to stop upon game over. | 
Ensure that the method StopParticles() is called when the game over event occurs, usually from a game management script or a controller handling game state transitions.

# Script 62 - TaggedBoolScript: Button Interactivity Management
This script manages the interactability of several buttons based on a boolean flag and scene loading state.

Public Variables:
taggedBool- A static boolean variable used to control button interactability, initialized to false. 

audioButton- Reference to the button that controls audio settings. 

controlButton- Reference to the button that controls game settings. 

creditButton- Reference to the button that displays credits. 

optionButton- Reference to the button for additional options.

Private Variables:
sceneLoaded- A boolean flag indicating whether the scene has been loaded once, initialized to false.

Methods:
Start()-
Retrieves the SceneLoaded value from PlayerPrefs. | 
If the value is 0, it sets sceneLoaded to true and updates the PlayerPrefs to indicate that the scene has been loaded once (set to 2). 

Update()-
Checks if taggedBool is true and the scene has been loaded. | 
If both conditions are met, it sets the interactable property of all referenced buttons to true, making them clickable.

Notes:
Attach this script to a GameObject that needs to manage button states based on specific conditions. | 
Ensure that taggedBool is set to true at the appropriate time in your game to enable the buttons. | 
The PlayerPrefs system is used to persist and retrieve the scene load state, allowing the buttons to be enabled only once the scene has been loaded.

# Script 63 - TimerManager: Score and Timer Display
This script manages and updates a score display based on elapsed time. It continuously increments the score and ensures the score is displayed with leading zeros.

Public Variables:
scoreText- Reference to the UI Text component that displays the score.

Private Variables:
score- A float variable to track the elapsed time and score. 

displayedScore- An integer to hold the score value to be displayed, ensuring it's rounded and formatted properly.

Methods:
Update()-
Checks if GlobalSubstance.obstacleTriggered is false. | 
If false, it continuously increments score based on Time.deltaTime, which represents the time passed since the last frame. | 
Converts the score from a float to an integer (displayedScore) using Mathf.FloorToInt to round down. | 
Updates the scoreText UI element to display the displayedScore with leading zeros (D5 format), ensuring a consistent length of 5 digits.

Notes:
Attach this script to a GameObject that manages score or time display in your game. | 
Ensure the scoreText reference is assigned in the Unity Inspector to connect it to the correct UI element. | 
The score will continuously increase as long as GlobalSubstance.obstacleTriggered is false, allowing for dynamic score tracking and display.

# Script 64 - ToggleAudioButton: Manage Button Visibility and UI Elements
This script manages the visibility and interactability of UI elements related to an audio button and other UI components. It also controls the transparency of a UI overlay and ensures the audio button is brought to the front of the hierarchy.

Public Variables:
audioButtonParent- Reference to the parent GameObject of the audio button.

Background- Reference to the UI overlay element.

audioButton- Reference to the Audio Button.

controlButton- Reference to the Control Button.

creditButton- Reference to the Credit Button.

optionButton- Reference to the Option Button.

Private Variables:
isBoolOne, isBoolTwo, isBoolThree, isBoolFour- Boolean flags for button states, sourced from ToggleOptionsButton.

isOptionsButtonVisibility, isAudioButtonVisibility, isCreditsButtonVisibility, isControlsButtonVisibility- Visibility states of various buttons.

isHideButtonOne, isHideButtonTwo, isHideButtonThree, isHideButtonFour- Flags for hiding specific buttons.

areElementsVisible- Tracks the visibility of UI elements.

controlSwitch- Static boolean used to manage control visibility.

audioButtonTransform- Transform component of the Audio Button panel.

audioSwitch- Boolean to manage the audio button's interaction state.

Methods:
Start()-
Initializes audioSwitch to true. | 
Retrieves the transform component of the audio button's parent and hides UI elements initially.

OnAudioButtonClick()-
Toggles the visibility and interactability of UI elements based on the flipSwitch variable from BackArrowButton4. | 
Updates various boolean flags to reflect the state of the audio button and other related buttons. | 
Calls ShowElements() or HideElements() based on the current visibility state. | 
Moves the audio button to the front of the hierarchy using BringAudioButtonToFront().

ShowElements()-
Sets all child elements within the audio button panel to active. | 
Adjusts the background overlay to a semi-transparent state.

HideElements()-
Deactivates the audio button if isHideButtonTwo is true. | 
Sets all child elements within the audio button panel to inactive. | 
Makes the background overlay fully transparent.

BringAudioButtonToFront()-
Moves the audio button to the front of the sibling hierarchy to ensure it is visually on top of other elements.

Notes:
Attach this script to a GameObject responsible for managing audio button interactions. | 
Ensure all references (audioButtonParent, Background, audioButton, controlButton, creditButton, optionButton) are assigned in the Unity Inspector. | 
ToggleOptionsButton and BackArrowButton4 need to be properly defined with the relevant static variables for this script to function correctly.

# Script 65 - ToggleControlsButton: Manage Controls Button and UI Elements
This script handles the visibility and interactability of UI elements related to a controls button. It also manages the transparency of a UI overlay and ensures the controls button is brought to the front of the hierarchy.

Public Variables:
controlButtonParent- Reference to the parent GameObject of the controls button.

Background- Reference to the UI overlay element.

controlButton- Reference to the Controls Button.

audioButton- Reference to the Audio Button.

creditButton- Reference to the Credit Button.

optionButton- Reference to the Option Button.

Private Variables-
isBoolOne, isBoolTwo, isBoolThree, isBoolFour- Boolean flags for button states, sourced from ToggleOptionsButton.

isOptionsButtonVisibility, isAudioButtonVisibility, isCreditsButtonVisibility, isControlsButtonVisibility- Visibility states of various buttons.

isHideButtonOne, isHideButtonTwo, isHideButtonThree, isHideButtonFour- Flags for hiding specific buttons.

areElementsVisible- Tracks the visibility of UI elements.

controlSwitch- Static boolean used to manage control visibility.

controlButtonTransform- Transform component of the controls button panel.

newFoundSwitch- Boolean to manage the new state of the controls button.

Methods:
Start()-
Initializes newFoundSwitch to true. | 
Retrieves the transform component of the controls button's parent and hides UI elements initially.

OnControlsButtonClick()-
Toggles the visibility and interactability of UI elements based on the flipSwitch variable from BackArrowButton3. |
Updates various boolean flags to reflect the state of the controls button and other related buttons. | 
Calls ShowElements() or HideElements() based on the current visibility state. | 
Moves the controls button to the front of the hierarchy using BringControlsButtonToFront().

ShowElements()-
Sets all child elements within the controls button panel to active. | 
Adjusts the background overlay to a semi-transparent state.

HideElements()-
Deactivates the controls button if isHideButtonFour is true. | 
Sets all child elements within the controls button panel to inactive. | 
Makes the background overlay fully transparent.

BringControlsButtonToFront()-
Moves the controls button to the front of the sibling hierarchy to ensure it is visually on top of other elements.

Notes:
Attach this script to a GameObject responsible for managing controls button interactions. | 
Ensure all references (controlButtonParent, Background, controlButton, audioButton, creditButton, optionButton) are assigned in the Unity Inspector. | 
ToggleOptionsButton and BackArrowButton3 need to be properly defined with the relevant static variables for this script to function correctly.

# Script 66 - ToggleCreditsButton: Manage Credits Button and UI Elements
This script manages the visibility and interactability of UI elements associated with the credits button. It also controls the transparency of a UI overlay and ensures the credits button is brought to the front of the hierarchy.

Public Variables:
creditButtonParent- Reference to the parent GameObject of the credits button.

Background- Reference to the UI overlay element.

creditButton- Reference to the Credits Button.

audioButton- Reference to the Audio Button.

optionButton- Reference to the Option Button.

controlButton- Reference to the Controls Button.

Private Variables-
isBoolOne, isBoolTwo, isBoolThree, isBoolFour- Boolean flags for button states, sourced from ToggleOptionsButton.

isOptionsButtonVisibility, isAudioButtonVisibility, isCreditsButtonVisibility, isControlsButtonVisibility- Visibility states of various buttons.

isHideButtonOne, isHideButtonTwo, isHideButtonThree, isHideButtonFour- Flags for hiding specific buttons.

areElementsVisible- Tracks the visibility of UI elements.

controlSwitch- Static boolean used to manage control visibility.

creditButtonTransform- Transform component of the credits button panel.

creditSwitch- Boolean to manage the new state of the credits button.

Methods:
Start()-
Initializes creditSwitch to true. | 
Retrieves the transform component of the credits button's parent and hides UI elements initially.

OnCreditButtonClick()-
Toggles the visibility and interactability of UI elements based on the flipSwitch variable from BackArrowButton2. | 
Updates various boolean flags to reflect the state of the credits button and other related buttons. | 
Calls ShowElements() or HideElements() based on the current visibility state. | 
Moves the credits button to the front of the hierarchy using BringCreditsButtonToFront().

ShowElements()-
Sets all child elements within the credits button panel to active. | 
Adjusts the background overlay to a semi-transparent state.

HideElements()-
Deactivates the credits button if isHideButtonThree is true. | 
Sets all child elements within the credits button panel to inactive. | 
Makes the background overlay fully transparent.

BringCreditsButtonToFront()-
Moves the credits button to the front of the sibling hierarchy to ensure it is visually on top of other elements.

Notes:
Attach this script to a GameObject responsible for managing credits button interactions. | 
Ensure all references (creditButtonParent, Background, creditButton, audioButton, optionButton, controlButton) are assigned in the Unity Inspector. | 
ToggleOptionsButton and BackArrowButton2 need to be properly defined with the relevant static variables for this script to function correctly.

# Script 67 - ToggleOptionsButton: Manage Options Button and UI Elements
This script handles the visibility and interactability of UI elements related to the options button. It also controls the transparency of a UI overlay and ensures the options button is brought to the front of the hierarchy.

Public Variables:
optionButtonParent- Reference to the parent GameObject of the options button.

Background- Reference to the UI overlay element.

optionButton- Reference to the Options Button.

creditButton- Reference to the Credits Button.

audioButton- Reference to the Audio Button.

controlButton- Reference to the Controls Button.

Static Variables-
boolOne, boolTwo, boolThree, boolFour- Boolean flags for button states.

optionsButtonVisibility, audioButtonVisibility, creditsButtonVisibility, controlsButtonVisibility- Visibility states of various buttons.

hideButtonOne, hideButtonTwo, hideButtonThree, hideButtonFour- Flags for hiding specific buttons.

Private Variables-
areElementsVisible- Tracks the visibility of UI elements.

optionButtonTransform- Transform component of the options button panel.

optionSwitch- Boolean to manage the state of the options button.

Methods:
Start()-
Initializes optionSwitch to true. | 
Retrieves the transform component of the options button's parent and hides UI elements initially.

OnOptionButtonClick()-
Toggles the visibility and interactability of UI elements based on the flipSwitch variable from BackArrowButton1. | 
Updates various boolean flags to reflect the state of the options button and other related buttons. | 
Calls ShowElements() or HideElements() based on the current visibility state. | 
Moves the options button to the front of the hierarchy using BringOptionsButtonToFront().

ShowElements()-
Sets all child elements within the options button panel to active. | 
Adjusts the background overlay to a semi-transparent state.

HideElements()-
Deactivates the options button if boolOne is true. | 
Sets all child elements within the options button panel to inactive. | 
Makes the background overlay fully transparent.

BringOptionsButtonToFront()-
Moves the options button to the front of the sibling hierarchy to ensure it is visually on top of other elements.

Notes:
Attach this script to a GameObject responsible for managing options button interactions. | 
Ensure all references (optionButtonParent, Background, optionButton, creditButton, audioButton, controlButton) are assigned in the Unity Inspector. | 
BackArrowButton1 needs to be properly defined with the relevant static variables for this script to function correctly.

# Script 68 - VolumeInitializer: Initialize Volume Settings from PlayerPrefs
This script sets up volume sliders based on saved preferences, updating both music and sound effect volumes accordingly.

Public Variables:
musicVolumeSlider- Reference to the slider controlling music volume.

soundEffectVolumeSlider- Reference to the slider controlling sound effect volume.

Methods:
Start()-
Calls InitializeVolumeSliders() to set up sliders with saved volume settings. | 

InitializeVolumeSliders()-
Checks if saved volume preferences for music and sound effects exist in PlayerPrefs. | 
Retrieves and applies the saved volume values to the corresponding sliders and updates the audio volumes. | 

UpdateBackgroundMusicVolume(float volume)-
Finds the BackgroundMusic1 component and sets its AudioSource volume to the specified level. | 
Ensure the BackgroundMusic1 script is attached to an appropriate GameObject with an AudioSource component. | 

UpdateSoundEffectVolume(float volume)-
Placeholder method to update sound effect volume. | 
Modify this method to fit your sound effects management setup.

Notes:
Attach this script to a GameObject responsible for initializing audio settings. | 
Ensure that musicVolumeSlider and soundEffectVolumeSlider references are assigned in the Unity Inspector. | 
Implement sound effect volume updating based on your specific sound effects management approach.

# Script 69 - VolumeSlider1: Manage Background Music Volume with Slider
This script allows users to adjust the background music volume using a slider and saves the volume setting for future sessions.

Public Variables:
volumeSlider- Reference to the slider UI element that controls volume.

Private Variables:
backgroundMusicAudioSource- Reference to the AudioSource component managing background music.

musicVolumeKey- Key used for saving and retrieving volume settings in PlayerPrefs.

Methods:
Start()-
Finds the AudioSource component and initializes the slider with the saved volume value if it exists in PlayerPrefs. | 
Updates the AudioSource volume based on the slider's value.

ChangeVolume()-
Adjusts the AudioSource volume based on the current slider value. | 
Saves the new volume setting to PlayerPrefs.

SaveVolume()-
Saves the current volume slider value to PlayerPrefs. | 

UpdateBackgroundMusicVolume()-
Updates the AudioSource volume based on the slider's value.

Notes:
Attach this script to a GameObject that manages the volume slider. | 
Ensure the volumeSlider reference is assigned in the Unity Inspector. | 
Adjust the FindObjectOfType<AudioSource>() line if your setup uses a different method to manage background music.

# Script 70 - VolumeSlider2: Manage Sound Effect Volume with Slider
This script controls the volume of sound effects through a slider, saves the volume setting, and updates a global volume variable.

Public Variables:
soundPlayer1- Reference to the AudioSource managing sound effects.

Serialized Variables:
volumeSlider- Reference to the slider UI element for adjusting volume.

Methods:
Start()-
Initializes the slider with the saved volume value if it exists in PlayerPrefs. | 
Updates the AudioSource volume based on the slider's value.

ChangeVolume()-
Adjusts the AudioSource volume based on the slider value. | 
Saves the new volume setting to PlayerPrefs. | 
Updates the global volume variable GlobalVolume.ButtonVolume.

SaveVolume()-
Saves the current volume slider value to PlayerPrefs and ensures the settings are written to disk. | 

UpdateSoundEffectVolume():-
Updates the AudioSource volume based on the slider's value. 

Notes:
Attach this script to a GameObject managing the volume slider. | 
Assign the soundPlayer1 reference and volumeSlider in the Unity Inspector. | 
Make sure the GlobalVolume class has a ButtonVolume variable for the global volume.
