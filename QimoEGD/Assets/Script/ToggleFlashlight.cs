using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// Turn off/on flashlight
    /// </summary>
    public class ToggleFlashlight : MonoBehaviour
    {

        public GameObject flashlight;
        public bool toggle;
        public AudioSource toggleSound;

        void Start()
        {
            if (toggle == false)
            {
                flashlight.SetActive(false);
            }
            if (toggle == true)
            {
                flashlight.SetActive(true);
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                toggle = !toggle;
                toggleSound.Play();
                if (toggle == false)
                {
                    flashlight.SetActive(false);
                }
                if (toggle == true)
                {
                    flashlight.SetActive(true);
                }
            }
        }
    }
}