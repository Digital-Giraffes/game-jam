using System.Collections;
using System.Collections.Generic;
using model;
using UnityEngine;

public class flag : MonoBehaviour
{
    private PlayerModel _player_model;
    
    private void Awake()
    {
        _player_model = GameObject.FindObjectOfType<PlayerModel>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _player_model.Won();
        }
    }
}
