using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

namespace model
{
  public class PlayerModel : MonoBehaviour
  {
    [SerializeField] private view.PlayerView _player_v;

    [SerializeField] private float _speed = 0f;
    private Vector2 _move_direction;

    private void FixedUpdate()
    {
      _player_v.ChangePosition(_move_direction * _speed * Time.deltaTime);
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