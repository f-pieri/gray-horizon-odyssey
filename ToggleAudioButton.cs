using UnityEngine;
using UnityEngine.UI;

public class ToggleAudioButton : MonoBehaviour
{
    public GameObject audioButtonParent;
    public GameObject Background; //I'm referencing the UI overlay

    bool isBoolOne = ToggleOptionsButton.boolOne; //Options Button
    bool isBoolTwo = ToggleOptionsButton.boolTwo; //Audio Button
    bool isBoolThree = ToggleOptionsButton.boolThree; //Credits Button
    bool isBoolFour = ToggleOptionsButton.boolFour; //Controls Button
    bool isOptionsButtonVisibility = ToggleOptionsButton.optionsButtonVisibility;
    bool isAudioButtonVisibility = ToggleOptionsButton.audioButtonVisibility;
    bool isCreditsButtonVisibility = ToggleOptionsButton.creditsButtonVisibility;
    bool isControlsButtonVisibility = ToggleOptionsButton.controlsButtonVisibility;
    bool isHideButtonOne = ToggleOptionsButton.hideButtonOne;
    bool isHideButtonTwo = ToggleOptionsButton.hideButtonTwo;
    bool isHideButtonThree = ToggleOptionsButton.hideButtonThree;
    bool isHideButtonFour = ToggleOptionsButton.hideButtonFour;

    private bool areElementsVisible = false;

    //I'm declaring controlSwitch as public static and setting it to false
    public static bool controlSwitch = false;

    private Transform audioButtonTransform; //I'm referencing the transform components of the Audio Button panel
    private bool audioSwitch = false;

    public Button audioButton;

    [SerializeField]
    private Button controlButton;

    [SerializeField]
    private Button creditButton;

    [SerializeField]
    private Button optionButton;

    void Start()
    {
        audioSwitch = true;

        audioButtonTransform = audioButtonParent.transform; //I'm getting the transform components of the Audio Button panel
        HideElements();
    }

    public void OnAudioButtonClick()
    {
        //I'm checking the flipSwitch variable from BackArrowButton4 script
        bool flipSwitch = BackArrowButton4.flipSwitch;

        //I'm declaring the conditiont that if flipSwitch is true, don't hide the UI elements
        if (flipSwitch)
        {
            controlSwitch = true; //I'm setting controlSwitch to true
            ShowElements();
            if (audioSwitch)
            {
                audioButton.interactable = false;
            }

            isBoolTwo = true;

            if (isBoolTwo)
            {
                isBoolOne = false;
                isBoolThree = false;
                isBoolFour = false;
                isAudioButtonVisibility = true;
                isHideButtonTwo = false;

                if (isAudioButtonVisibility)
                {
                    isOptionsButtonVisibility = false;
                    isCreditsButtonVisibility = false;
                    isControlsButtonVisibility = false;

                    if (isOptionsButtonVisibility == false)
                    {
                        isHideButtonOne = true;

                        Debug.Log("Options button unclickable.");
                        optionButton.interactable = false;
                    }

                    if (isCreditsButtonVisibility == false)
                    {
                        isHideButtonThree = true;

                        Debug.Log("Credits button unclickable.");
                        creditButton.interactable = false;
                    }

                    if (isControlsButtonVisibility == false)
                    {
                        isHideButtonFour = true;

                        Debug.Log("Controls button unclickable.");
                        controlButton.interactable = false;
                    }
                }
            }
    }
        else
        {
            areElementsVisible = !areElementsVisible;

            if (areElementsVisible)
            {
                ShowElements();
                if (audioSwitch)
                {
                    audioButton.interactable = false;
                }

                isBoolTwo = true;

                if (isBoolTwo)
                {
                    isBoolOne = false;
                    isBoolThree = false;
                    isBoolFour = false;
                    isAudioButtonVisibility = true;
                    isHideButtonTwo = false;

                    if (isAudioButtonVisibility)
                    {
                        isOptionsButtonVisibility = false;
                        isCreditsButtonVisibility = false;
                        isControlsButtonVisibility = false;

                        if (isOptionsButtonVisibility == false)
                        {
                            isHideButtonOne = true;

                            Debug.Log("Options button unclickable.");
                            optionButton.interactable = false;
                        }

                        if (isCreditsButtonVisibility == false)
                        {
                            isHideButtonThree = true;

                            Debug.Log("Credits button unclickable.");
                            creditButton.interactable = false;
                        }

                        if (isControlsButtonVisibility == false)
                        {
                            isHideButtonFour = true;

                            Debug.Log("Controls button unclickable.");
                            controlButton.interactable = false;
                        }
                    }
                }
            }
            else
            {
                HideElements();
            }
        }

        BringAudioButtonToFront(); //I'm moving the button to the front of the hierarchy
        Debug.Log("UI elements are now visible.");
        if (flipSwitch)
        {
            BackArrowButton4.flipSwitch = false; //I'm resetting flipSwitch
        }
    }

    private void ShowElements()
    {
        //I'm setting all child elements within the Audio Button to active
        foreach (Transform child in audioButtonTransform)
        {
            child.gameObject.SetActive(true);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f); //I'm adjusting the alpha to control the overlay's transparency
    }

    private void HideElements()
    {
        if (isHideButtonTwo)
        {
            audioButton.interactable = false;
        }

        //I'm setting all child elements within the Audio Button to inactive
        foreach (Transform child in audioButtonTransform)
        {
            child.gameObject.SetActive(false);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0); //I'm making the overlay fully transparent
    }

    private void BringAudioButtonToFront()
    {
        //I'm setting the sibling index of the Audio Button to be the highest (in front of everything else)
        audioButtonTransform.SetAsLastSibling();
    }
}