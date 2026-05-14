using UnityEngine;
using UnityEngine.UI;

public class BackArrowButton2 : MonoBehaviour
{
    public Button audioButton; //I referenced the Audio Button
    public Button controlButton; //I referenced the Control Button
    public Button creditButton; //I referenced the Credit Button
    public Button optionButton; //I referenced the Option Button

    //I declared flipSwitch as public static so it can be accessed from other scripts
    public static bool flipSwitch = false;

    public void OnBackArrowClick()
    {
        //I checked if the Audio Button is not null
        if (audioButton != null)
        {
            //I toggled the visibility of all child GameObjects within the Audio Button
            ToggleChildVisibility(audioButton.gameObject, !audioButton.gameObject.activeSelf);
        }

        //I checked  if the Control Button is not null
        if (controlButton != null)
        {
            //I toggled the visibility of all child GameObjects within the Control Button
            ToggleChildVisibility(controlButton.gameObject, !controlButton.gameObject.activeSelf);
        }

        //I checked if the Credit Button is not null
        if (creditButton != null)
        {
            //I toggled the visibility of all child GameObjects within the Credit Button
            ToggleChildVisibility(creditButton.gameObject, !creditButton.gameObject.activeSelf);
        }

        //I checked if the Option Button is not null
        if (optionButton != null)
        {
            //I toggled the visibility of all child GameObjects within the Option Button
            ToggleChildVisibility(optionButton.gameObject, !optionButton.gameObject.activeSelf);
        }

        //I toggled the flipSwitch variable
        flipSwitch = !flipSwitch;

        //I reset  the interactability of the buttons
        audioButton.interactable = true;
        controlButton.interactable = true;
        creditButton.interactable = true;
        optionButton.interactable = true;

        Debug.Log("flipSwitch is now: " + flipSwitch);
    }

    private void ToggleChildVisibility(GameObject parent, bool active)
    {
        //I looped through all child GameObjects within the parent
        foreach (Transform child in parent.transform)
        {
            child.gameObject.SetActive(active);
        }
    }
}