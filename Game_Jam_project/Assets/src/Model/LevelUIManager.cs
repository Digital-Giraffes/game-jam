using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace model
{
    public class LevelUIManager : MonoBehaviour
    {
        public static void NextLevel()
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)% 11);
        }

        public static void ExitToLevelSelect()
        {
            SceneManager.LoadScene(0);
        }

        public static void RetryCurrentLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }   
}
