using control;
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

    public void Move(Vector2 direction)
    {
      playerView.Walking(direction, _onCarpet);
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