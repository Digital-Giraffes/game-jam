using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorModel : MonoBehaviour
{
	[SerializeField] private Collider2D _collider;

	private void Awake()
	{
		_collider = gameObject.GetComponent<Collider2D>();
	}
}
