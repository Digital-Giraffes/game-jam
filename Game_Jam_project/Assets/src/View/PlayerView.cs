using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
  public class PlayerView : MonoBehaviour
  {
    [SerializeField] private AudioSource _walking_sound;
    private bool _is_walking = false;

    private void Awake()
    {
      _walking_sound = gameObject.GetComponent<AudioSource>();
    }

    public void Walking(Vector3 delta_position, bool on_carpet)
    {
      ChangePosition(delta_position);
      Sounds(on_carpet);
    }

    private void ChangePosition(Vector3 delta_position)
    {
      gameObject.transform.position += delta_position;
    }

    private void SetPosition(Vector3 new_position)
    {
      gameObject.transform.position = new_position;
    }

    private void Sounds(bool on_carpet)
    {
      if (!_is_walking && !on_carpet)
      {
        _walking_sound.Play();
        _is_walking = true;
      }
      else if (on_carpet && _is_walking)
      {
        _walking_sound.Pause();
      }
    }
  }
}
