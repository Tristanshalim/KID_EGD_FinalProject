using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace tristan
{
    /// <summary>
    /// reload to main menu 
    /// </summary>
    public class ReloadScene : MonoBehaviour
    {
        public string SceneName;
        public float waitTime;

        void Start()
        {
            StartCoroutine(loadToMenu());
        }
        IEnumerator loadToMenu()
        {
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(SceneName);
        }
    }
}