using UnityEngine;
using UnityEngine.UI;

public class ToggleCreditsButton : MonoBehaviour
{
    public GameObject creditButtonParent;
    public GameObject Background; //I'm referencing the UI overlay

    bool isBoolOne = ToggleOptionsButton.boolOne;  //Options Button
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

    private Transform creditButtonTransform; //I'm referencing the transform components of the credit Button panel
    private bool creditSwitch = false;

    public Button creditButton;

    [SerializeField]
    private Button audioButton;

    [SerializeField]
    private Button optionButton;

    [SerializeField]
    private Button controlButton;

    void Start()
    {
        creditSwitch = true;

        creditButtonTransform = creditButtonParent.transform; //I'm getting the transform components of the credits Button panel
        HideElements();
    }

    public void OnCreditButtonClick()
    {
        //I'm checking the flipSwitch variable from BackArrowButton2 script
        bool flipSwitch = BackArrowButton2.flipSwitch;

        //I'm declaring the conditiont that if flipSwitch is true, don't hide the UI elements
        if (flipSwitch)
        {
            controlSwitch = true; //I'm setting controlSwitch to true
            ShowElements();
            if (creditSwitch)
            {
                creditButton.interactable = false;
            }

            isBoolThree = true;

            if (isBoolThree)
            {
                isBoolTwo = false;
                isBoolOne = false;
                isBoolFour = false;
                isCreditsButtonVisibility = true;
                isHideButtonThree = false;

                if (isCreditsButtonVisibility)
                {
                    isAudioButtonVisibility = false;
                    isOptionsButtonVisibility = false;
                    isControlsButtonVisibility = false;

                    if (isAudioButtonVisibility == false)
                    {
                        isHideButtonTwo = true;

                        Debug.Log("Audio button unclickable.");
                        audioButton.interactable = false;
                    }

                    if (isOptionsButtonVisibility == false)
                    {
                        isHideButtonOne = true;

                        Debug.Log("Options button unclickable.");
                        optionButton.interactable = false;
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
                if (creditSwitch)
                {
                    creditButton.interactable = false;
                }

                isBoolThree = true;

                if (isBoolThree)
                {
                    isBoolTwo = false;
                    isBoolOne = false;
                    isBoolFour = false;
                    isCreditsButtonVisibility = true;
                    isHideButtonThree = false;

                    if (isCreditsButtonVisibility)
                    {
                        isAudioButtonVisibility = false;
                        isOptionsButtonVisibility = false;
                        isControlsButtonVisibility = false;

                        if (isAudioButtonVisibility == false)
                        {
                            isHideButtonTwo = true;

                            Debug.Log("Audio button unclickable.");
                            audioButton.interactable = false;
                        }

                        if (isOptionsButtonVisibility == false)
                        {
                            isHideButtonOne = true;

                            Debug.Log("Options button unclickable.");
                            optionButton.interactable = false;
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

        BringCreditsButtonToFront(); //I'm moving the button to the front of the hierarchy
        Debug.Log("UI elements are now visible.");
        if (flipSwitch)
        {
            BackArrowButton2.flipSwitch = false;  //I'm resetting flipSwitch
        }
    }

    private void ShowElements()
    {
        //I'm setting all child elements within the credits Button to active
        foreach (Transform child in creditButtonTransform)
        {
            child.gameObject.SetActive(true);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f); //I'm adjusting the alpha to control the overlay's transparency
    }

    private void HideElements()
    {
        if (isHideButtonThree)
        {
            creditButton.interactable = false;
        }

        //I'm setting all child elements within the credits Button to inactive
        foreach (Transform child in creditButtonTransform)
        {
            child.gameObject.SetActive(false);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0); //I'm making the overlay fully transparent
    }

    private void BringCreditsButtonToFront()
    {
        //I'm setting the sibling index of the credits Button to be the highest (in front of everything else)
        creditButtonTransform.SetAsLastSibling();
    }
}
