using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace src.Control
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public GameObject mainMenu;
        public GameObject levelSelect;
        public GameObject settings;
        public GameObject currentActive;

        public void Start()
        {
            currentActive = mainMenu;
        }

        public void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                LoadMenu("MainMenu");
            }
        }

        public void LoadMenu(string menuName)
        {
            currentActive.SetActive(false);
            currentActive = menuName switch
            {
                "LevelSelect" => levelSelect,
                "MainMenu" => mainMenu,
                "Settings" => settings,
                _ => currentActive
            };
            currentActive.SetActive(true);
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void LoadLevel(int num)
        {
            
        }
    }
}