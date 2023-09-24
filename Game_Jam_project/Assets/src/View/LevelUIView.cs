using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
    public class LevelUIView : MonoBehaviour
    {
        [SerializeReference] private GameObject eyeUI;
        [SerializeReference] private Image eyeScreen;
        [SerializeReference] private UIDoubleBar eyeBar;
        [SerializeReference] private GameObject lostScreen;
        [SerializeReference] private GameObject wonScreen;
        [SerializeReference] private Image backgroundUI; 

        public void OpenEyes()
        {
            eyeScreen.enabled = false;
        }

        public void CloseEyes()
        {
            eyeScreen.enabled = true;
        }

        public void UpdateEyeBar(float delta)
        {
            eyeBar.UpdateValue(delta);
        }

        public void Configure(float maxEyesTime)
        {
            eyeBar.SetMaxValue(maxEyesTime);
            eyeBar.SetValue(maxEyesTime);
            eyeScreen.enabled = true;
        }

        private void DisableEye()
        {
            eyeUI.SetActive(false);
            backgroundUI.enabled = true;
        }
        
        public void Lost()
        {
            DisableEye();
            lostScreen.SetActive(true);
        }

        public void Won()
        {
            DisableEye();
            wonScreen.SetActive(true);
        }
    }
}