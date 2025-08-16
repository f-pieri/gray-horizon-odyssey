using UnityEngine;

namespace YourNamespace1
{
    public class candleStickControl : MonoBehaviour
    {
        public AudioSource soundPlayer1; // Reference to the sound player

        // Update is called once per frame
        void Update()
        {
            // Check if candleStick from SoundManager4 is true
            if (SoundManager4.candleStick)
            {
                // Play music when candleStick is true
                soundPlayer1.Play();
            }
        }
    }
}