using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace tristan
{
    /// <summary>
    /// win menu
    /// </summary>
    public class Win : MonoBehaviour
    {
        public string sceneName;

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}