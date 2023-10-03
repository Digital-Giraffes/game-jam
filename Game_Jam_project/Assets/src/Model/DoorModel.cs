using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace model
{
	public class DoorModel : MonoBehaviour
	{
		private Collider2D _collider;
		private SpriteRenderer _sprite;
		private GameModel _gameModel;

		private void Awake()
		{
			_collider = gameObject.GetComponent<Collider2D>();
			_gameModel = FindObjectOfType<GameModel>();
			_sprite = gameObject.GetComponent<SpriteRenderer>();
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.CompareTag("Player"))
			{
				_gameModel.Lost();
			}
		}

		public void Open()
		{
			_collider.enabled = false;
			_sprite.enabled = false;
		}

		public void Close()
		{
			_collider.enabled = true;
			_sprite.enabled = true;
		}
	}
}

