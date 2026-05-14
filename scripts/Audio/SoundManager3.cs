using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;           //BUTTON SOUND

namespace YourNamespace
{
    public class SoundManager3 : MonoBehaviour
    {
        [SerializeField] Image soundOnIcon; //I'm using serialized fields to constantly update sound on/off icons
        [SerializeField] Image soundOffIcon; //I'm using serialized fields to constantly update sound on/off icons

        //I'm calling the awake function
        void Awake()
        {
            //UpdateButtonIcon();
        }

        //I'm calling the start function
        void Start()
        {
          //Not needed anything here
        }

        //I'm calling the update function
        void Update()
        {
            //Not needed anything here
        }

        //I'm calling this method when the action is performed
        public void OnButtonpress()
        {
            //I'm toggling the Checkmark variable (for testing purposes)
            GlobalVariables.Checkmark = !GlobalVariables.Checkmark;

            //I'm updating the button icons
            UpdateButtonIcon();
        }

        private void UpdateButtonIcon()
        {
            if (GlobalVariables.Checkmark)
            {
                soundOnIcon.enabled = false;
                soundOffIcon.enabled = true;
                Debug.Log("Sound Icon has changed to false.");
            }
            else
            {
                soundOnIcon.enabled = true;
                soundOffIcon.enabled = false;
                Debug.Log("Sound Icon has changed to true.");
            }

            //I'm forcing a UI Update
            Canvas.ForceUpdateCanvases(); 
        }
    }
}
