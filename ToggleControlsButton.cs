using UnityEngine;
using UnityEngine.UI;

public class ToggleControlsButton : MonoBehaviour
{
    public GameObject controlButtonParent;
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

    private Transform controlButtonTransform; //I'm referencing the transform components of the control Button panel
    private bool newFoundSwitch = false;

    public Button controlButton;

    [SerializeField]
    private Button audioButton;

    [SerializeField]
    private Button creditButton;

    [SerializeField]
    private Button optionButton;

    void Start()
    {
        newFoundSwitch = true;

        controlButtonTransform = controlButtonParent.transform; //I'm getting the transform components of the control Button panel
        HideElements();
    }

    public void OnControlsButtonClick()
    {
        //I'm checking the flipSwitch variable from BackArrowButton3 script
        bool flipSwitch = BackArrowButton3.flipSwitch;

        //I'm declaring the conditiont that if flipSwitch is true, don't hide the UI elements
        if (flipSwitch)
        {
            controlSwitch = true; //I'm setting controlSwitch to true
            ShowElements();
            if (newFoundSwitch)
            {
                controlButton.interactable = false;
            }

            isBoolFour = true;

            if (isBoolFour)
            {
                isBoolTwo = false;
                isBoolThree = false;
                isBoolOne = false;
                isControlsButtonVisibility = true;
                isHideButtonFour = false;

                if (isControlsButtonVisibility)
                {
                    isAudioButtonVisibility = false;
                    isCreditsButtonVisibility = false;
                    isOptionsButtonVisibility = false;

                    if (isAudioButtonVisibility == false)
                    {
                        isHideButtonTwo = true;

                        Debug.Log("Audio button unclickable.");
                        audioButton.interactable = false;
                    }

                    if (isCreditsButtonVisibility == false)
                    {
                        isHideButtonThree = true;

                        Debug.Log("Credits button unclickable.");
                        creditButton.interactable = false;
                    }

                    if (isOptionsButtonVisibility == false)
                    {
                        isHideButtonOne = true;

                        Debug.Log("Options button unclickable.");
                        optionButton.interactable = false;
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
                if (newFoundSwitch)
                {
                    controlButton.interactable = false;
                }

                isBoolFour = true;

                if (isBoolFour)
                {
                    isBoolTwo = false;
                    isBoolThree = false;
                    isBoolOne = false;
                    isControlsButtonVisibility = true;
                    isHideButtonFour = false;

                    if (isControlsButtonVisibility)
                    {
                        isAudioButtonVisibility = false;
                        isCreditsButtonVisibility = false;
                        isOptionsButtonVisibility = false;

                        if (isAudioButtonVisibility == false)
                        {
                            isHideButtonTwo = true;

                            Debug.Log("Audio button unclickable.");
                            audioButton.interactable = false;
                        }

                        if (isCreditsButtonVisibility == false)
                        {
                            isHideButtonThree = true;

                            Debug.Log("Credits button unclickable.");
                            creditButton.interactable = false;
                        }

                        if (isOptionsButtonVisibility == false)
                        {
                            isHideButtonOne = true;

                            Debug.Log("Options button unclickable.");
                            optionButton.interactable = false;
                        }
                    }
                }
            }
            else
            {
                HideElements();
            }
        }

        BringControlsButtonToFront(); //I'm moving the button to the front of the hierarchy
        Debug.Log("UI elements are now visible.");
        if (flipSwitch)
        {
            BackArrowButton3.flipSwitch = false;  //I'm resetting flipSwitch
        }
    }

    private void ShowElements()
    {
        //I'm setting all child elements within the control Button to active
        foreach (Transform child in controlButtonTransform)
        {
            child.gameObject.SetActive(true);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f); //I'm adjusting the alpha to control the overlay's transparency
    }

    private void HideElements()
    {
        if (isHideButtonFour)
        {
            controlButton.interactable = false;
        }

        //I'm setting all child elements within the controls Button to inactive
        foreach (Transform child in controlButtonTransform)
        {
            child.gameObject.SetActive(false);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0); //I'm making the overlay fully transparent
    }

    private void BringControlsButtonToFront()
    {
        //I'm setting the sibling index of the controls Button to be the highest (in front of everything else)
        controlButtonTransform.SetAsLastSibling();
    }
}
