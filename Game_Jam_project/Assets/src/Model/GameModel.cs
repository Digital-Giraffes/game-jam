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
    [SerializeReference] private GameObject gameObjects;
    [SerializeField] private float maxOpenedEyeTime = 0f;
    
    private float _openedEyeTime = 0f;
    private Vector2 _moveDirection = Vector2.zero;
    private bool _eyesOpened = false;

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
      playerView.Walking(direction);
    }

    public void Lost()
    {
      GameObject.FindWithTag("GameController").SetActive(false);
      gameObjects.SetActive(false);
      levelUIView.Lost();
    }

    public void Won()
    {
      GameObject.FindWithTag("GameController").SetActive(false);
      gameObjects.SetActive(false);
      levelUIView.Won();
    }
  }
}