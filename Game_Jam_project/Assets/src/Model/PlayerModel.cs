using control;
using NUnit.Framework;
using TMPro;
using TMPro.EditorUtilities;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using view;

namespace model
{
  public class PlayerModel : MonoBehaviour
  {
    [SerializeField] private view.PlayerView _player_view;
    [SerializeField] private view.UIView _UI_view = view.UIView.Instance;

    [SerializeField] private float _speed = 0f;
    private Vector2 _move_direction = Vector2.zero;
    private bool _eyes_opened = false;
    private bool _on_carpet = false;

    [SerializeField] private float _max_opened_eyes_time = 0f;
    [SerializeField] private float _opened_eyes_time = 0f;

    private void Awake()
    {
      _opened_eyes_time = _max_opened_eyes_time;
      _UI_view.Configure(_max_opened_eyes_time);
    }

    private void FixedUpdate()
    {
      if (_move_direction != Vector2.zero)
      {
        _player_view.Walking(_move_direction * _speed * Time.deltaTime, _on_carpet);
      }
      else
      {
        _player_view.Walking(Vector3.zero, true);
      }
      if (_eyes_opened)
      {
        _opened_eyes_time -= Time.deltaTime;
        _UI_view.UpdateEyeBar(-Time.deltaTime);
        if (_opened_eyes_time <= 0)
        {
          CloseEyes();
        }
      }
    }

    public void OpenEyes()
    {
      if (_opened_eyes_time > 0)
      {
        _UI_view.OpenEyes();
        _eyes_opened = true;
      }
    }

    public void CloseEyes()
    {
      _UI_view.CloseEyes();
      _eyes_opened = false;
    }

    public void SetSpeed(float new_speed)
    {
      _speed = new_speed;
    }

    public float GetSpeed()
    {
      return _speed;
    }

    public void SetMoveDirection(Vector2 new_move_direction)
    {
      _move_direction = new_move_direction;
    }

    public void SetCarpet(bool value)
    {
      _on_carpet = value;
    }

    public Vector2 GetMoveDirection()
    {
      return _move_direction;
    }

    public void Lost()
    {
      GameObject.FindObjectOfType<PlayerControls>().gameObject.SetActive(false);
      _UI_view.Lost();
    }

    public void Win()
    {
      GameObject.FindObjectOfType<PlayerControls>().gameObject.SetActive(false);
      
    }
  }
}