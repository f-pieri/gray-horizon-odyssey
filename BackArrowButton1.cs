using UnityEngine;
using UnityEngine.UI;

public class BackArrowButton1 : MonoBehaviour
{
    public static bool flipSwitch = false;

    public void OnBackArrowClick()
    {
        bool taggedBool = TaggedBoolScript.taggedBool;
        taggedBool = true;

        if (GlobalButtonReferences.Instance != null)
        {
            if (GlobalButtonReferences.Instance.audioButton != null)
            {
                ToggleChildVisibility(GlobalButtonReferences.Instance.audioButton.gameObject,
                    !GlobalButtonReferences.Instance.audioButton.gameObject.activeSelf);
            }

            if (GlobalButtonReferences.Instance.controlButton != null)
            {
                ToggleChildVisibility(GlobalButtonReferences.Instance.controlButton.gameObject,
                    !GlobalButtonReferences.Instance.controlButton.gameObject.activeSelf);
            }

            if (GlobalButtonReferences.Instance.creditButton != null)
            {
                ToggleChildVisibility(GlobalButtonReferences.Instance.creditButton.gameObject,
                    !GlobalButtonReferences.Instance.creditButton.gameObject.activeSelf);
            }

            if (GlobalButtonReferences.Instance.optionButton != null)
            {
                ToggleChildVisibility(GlobalButtonReferences.Instance.optionButton.gameObject,
                    !GlobalButtonReferences.Instance.optionButton.gameObject.activeSelf);
            }

            GlobalButtonReferences.Instance.audioButton.interactable = true;
            GlobalButtonReferences.Instance.controlButton.interactable = true;
            GlobalButtonReferences.Instance.creditButton.interactable = true;
            GlobalButtonReferences.Instance.optionButton.interactable = true;

            flipSwitch = !flipSwitch;
            Debug.Log("flipSwitch is now: " + flipSwitch);
        }
    }

    private void ToggleChildVisibility(GameObject parent, bool active)
    {
        foreach (Transform child in parent.transform)
        {
            child.gameObject.SetActive(active);
        }
    }
}
