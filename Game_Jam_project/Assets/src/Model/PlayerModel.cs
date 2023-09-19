using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;

namespace model
{
  public class PlayerModel : MonoBehaviour
  {
    [SerializeField] private view.PlayerView _player_view;

    [SerializeField] private float _speed = 0f;
    private Vector2 _move_direction = Vector2.zero;
    private bool _are_eyes_opened = false;

    private void FixedUpdate()
    {
      if (_move_direction != Vector2.zero)
      {
        _player_view.ChangePosition(_move_direction * _speed * Time.deltaTime);
      }
    }

    public void OpenEyes()
    {
      _player_view.OpenEyes();
      _are_eyes_opened = true;
    }

    public void CloseEyes()
    {
      _player_view.CloseEyes();
      _are_eyes_opened = false;
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

    public Vector2 GetMoveDirection()
    {
      return _move_direction;
    }
  }
}