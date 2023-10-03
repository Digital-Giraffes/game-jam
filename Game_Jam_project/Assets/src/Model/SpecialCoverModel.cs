using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace model
{
  public class SpecialCoverModel : MonoBehaviour
  {
    private AudioSource sound;

    private void Awake()
    {
      sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        sound.Play();
      }
    }
  }
}
