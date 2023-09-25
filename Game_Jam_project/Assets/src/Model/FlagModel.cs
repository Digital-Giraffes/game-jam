using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace model
{
    public class FlagModel : MonoBehaviour
    {
        private GameModel _gameModel;

        private void Awake()
        {
            _gameModel = GameObject.FindObjectOfType<GameModel>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _gameModel.Won();
            }
        }
    }
}