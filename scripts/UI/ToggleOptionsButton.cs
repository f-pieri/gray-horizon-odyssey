using UnityEngine;
using UnityEngine.UI;

public class ToggleOptionsButton : MonoBehaviour
{
    public GameObject optionButtonParent;
    public GameObject Background; //I'm referencing the UI overlay

    public static bool boolOne = false; //Options Button
    public static bool boolTwo = false; //Audio Button
    public static bool boolThree = false; //Credits Button
    public static bool boolFour = false; //Controls Button
    public static bool optionsButtonVisibility = false;
    public static bool audioButtonVisibility = false;
    public static bool creditsButtonVisibility = false;
    public static bool controlsButtonVisibility = false;
    public static bool hideButtonOne = false;
    public static bool hideButtonTwo = false;
    public static bool hideButtonThree = false;
    public static bool hideButtonFour = false;
    private bool areElementsVisible = false;

    private Transform optionButtonTransform;  //I'm referencing the transform components of the options Button panel
    private bool optionSwitch = false;

    public Button optionButton;

    [SerializeField] private Button creditButton;
    [SerializeField] private Button audioButton;
    [SerializeField] private Button controlButton;

    void Start()
    {
        optionSwitch = true;

        optionButtonTransform = optionButtonParent.transform; //I'm getting the transform components of the options Button panel
        HideElements();
    }

    public void OnOptionButtonClick()
    {
        bool flipSwitch = BackArrowButton1.flipSwitch;

        if (flipSwitch)
        {
            ShowElements();
            if (optionSwitch)
            {
                optionButton.interactable = false;
            }

            boolOne = true;

            if (boolOne)
            {
                boolTwo = false;
                boolThree = false;
                boolFour = false;

                if (boolTwo)
                {
                    audioButton.interactable = true;
                }

                if (boolThree)
                {
                    creditButton.interactable = true;
                }

                if (boolFour)
                {
                    controlButton.interactable = true;
                }
            }
        }
        else
        {
            areElementsVisible = !areElementsVisible;

            if (areElementsVisible)
            {
                ShowElements();
                if (optionSwitch)
                {
                    optionButton.interactable = false;
                }
            }
            else
            {
                HideElements();
            }
        }

        BringOptionsButtonToFront();
        if (flipSwitch)
        {
            BackArrowButton1.flipSwitch = false;
        }
    }

    private void ShowElements()
    {
        foreach (Transform child in optionButtonTransform)
        {
            child.gameObject.SetActive(true);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0.5f);
    }

    private void HideElements()
    {
        if (boolOne)
        {
            optionButton.interactable = false;
        }

        foreach (Transform child in optionButtonTransform)
        {
            child.gameObject.SetActive(false);
        }

        Background.GetComponent<Image>().color = new Color(0, 0, 0, 0);
    }

    private void BringOptionsButtonToFront()
    {
        optionButtonTransform.SetAsLastSibling();
    }
}