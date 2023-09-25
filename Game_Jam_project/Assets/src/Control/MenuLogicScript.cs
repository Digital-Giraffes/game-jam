using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace src.Control
{
  public class NewBehaviourScript : MonoBehaviour
  {
    public void LoadLevel(int num)
    {
      SceneManager.LoadScene(num);
    }
  }
}