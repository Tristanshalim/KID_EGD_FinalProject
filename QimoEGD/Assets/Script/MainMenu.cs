using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace tristan
{
    public class MainMenu : MonoBehaviour
    {
        /// <summary>
        /// Mainmenu to start game
        /// </summary>
        public string sceneName;

        void Start()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public void playGame()
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
