using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonModel : MonoBehaviour
{
  [SerializeField] private DoorModel _door;
  [SerializeField] private AudioSource _button_sound;

  private bool _door_opened = false;
  [SerializeField] float _close_door_timeout;

  private void Awake()
  {
    _button_sound = gameObject.GetComponent<AudioSource>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (!_door_opened)
    {
      _door.gameObject.SetActive(false);
      _button_sound.Play();
      Invoke("CloseDoor", _close_door_timeout);
      _door_opened = true;
    }
  }

  private void CloseDoor()
  {
    _door.gameObject.SetActive(true);
    _door_opened = false;
  }
}
