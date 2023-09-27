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
  public class GameModel : MonoBehaviour
  {
    [SerializeReference] private view.PlayerView playerView;
    [SerializeReference] private view.LevelUIView levelUIView;
    [SerializeField] private float speed = 0f;
    [SerializeField] private float maxOpenedEyeTime = 0f;
    
    private float _openedEyeTime = 0f;
    private Vector2 _moveDirection = Vector2.zero;
    private bool _eyesOpened = false;
    private bool _onCarpet = false;

    private void Awake()
    {
      _openedEyeTime = maxOpenedEyeTime;
      levelUIView.Configure(maxOpenedEyeTime);
    }

    private void FixedUpdate()
    {
      if (_moveDirection != Vector2.zero)
      {
        playerView.Walking(_moveDirection * (speed * Time.deltaTime), _onCarpet);
      }
      else
      {
        playerView.Walking(Vector3.zero, true);
      }
      if (_eyesOpened)
      {
        _openedEyeTime -= Time.deltaTime;
        levelUIView.UpdateEyeBar(-Time.deltaTime);
        if (_openedEyeTime <= 0)
        {
          CloseEyes();
        }
      }
    }

    public void OpenEyes()
    {
      if (_openedEyeTime > 0)
      {
        levelUIView.OpenEyes();
        _eyesOpened = true;
      }
    }

    public void CloseEyes()
    {
      levelUIView.CloseEyes();
      _eyesOpened = false;
    }

    public void SetMoveDirection(Vector2 new_move_direction)
    {
      _moveDirection = new_move_direction;
    }

    public void SetCarpet(bool value)
    {
      _onCarpet = value;
    }

    public void Lost()
    {
      GameObject.FindObjectOfType<PlayerControls>().gameObject.SetActive(false);
      levelUIView.Lost();
    }

    public void Won()
    {
      GameObject.FindObjectOfType<PlayerControls>().gameObject.SetActive(false);
      levelUIView.Won();
    }
  }
}