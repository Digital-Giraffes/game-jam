using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace model
{
  public class CarpetModel : MonoBehaviour
  {
    private AudioSource _carpet_sounds;
    private PlayerModel _player_model;

    private void Awake()
    {
      _carpet_sounds = gameObject.GetComponent<AudioSource>();
      _player_model = GameObject.FindObjectOfType<PlayerModel>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
      _carpet_sounds.Play();
      _player_model.SetCarpet(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
      _carpet_sounds.Pause();
      _player_model.SetCarpet(true);
    }
  }
}
