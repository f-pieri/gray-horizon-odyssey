using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YourNamespace1
{
    public class SoundManager4 : MonoBehaviour
    {
        [SerializeField] Image soundOnIcon; //I'm using serialized fields to constantly update sound on/off icons
        [SerializeField] Image soundOffIcon; //I'm using serialized fields to constantly update sound on/off icons
        public static bool candleStick = false;

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
            GlobalVariables1.newCheckmark = !GlobalVariables1.newCheckmark;

            //I'm updating the button icons
            UpdateButtonIcon();
        }

        private void UpdateButtonIcon()
        {
            if (GlobalVariables1.newCheckmark)
            {
                soundOnIcon.enabled = false;
                soundOffIcon.enabled = true;
                Debug.Log("Sound Icon has changed to false.");
                candleStick = false; //If candleStick = false, no sound
            }
            else
            {
                soundOnIcon.enabled = true;
                soundOffIcon.enabled = false;
                Debug.Log("Sound Icon has changed to true.");
                candleStick = true; //If candleStick = true, sound
            }

            //I'm forcing a UI Update
            Canvas.ForceUpdateCanvases();
        }
    }
}
