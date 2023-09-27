using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace model
{
  public class FloorModel : MonoBehaviour
  {
    private GameModel _gameModel;

    private void Awake()
    {
      _gameModel = GameObject.FindObjectOfType<GameModel>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
      if (other.tag == "Player")
      {
        _gameModel.Lost();
      }
    }
  }
}
