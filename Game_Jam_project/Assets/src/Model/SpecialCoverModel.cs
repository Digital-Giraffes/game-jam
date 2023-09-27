using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace model
{
  public class SpecialCoverModel : MonoBehaviour
  {
    private AudioSource _carpetSounds;
    private GameModel _gameModel;

    private void Awake()
    {
      _carpetSounds = gameObject.GetComponent<AudioSource>();
      _gameModel = GameObject.FindObjectOfType<GameModel>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
      _carpetSounds.Play();
      _gameModel.SetCarpet(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
      _carpetSounds.Pause();
      _gameModel.SetCarpet(false);
    }
  }
}
