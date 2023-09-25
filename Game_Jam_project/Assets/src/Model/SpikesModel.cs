using UnityEngine;
using UnityEngine.PlayerLoop;

namespace model
{
  public class SpikesModel : MonoBehaviour
  {
    public float period;
    private GameModel _gameModel;
    private AudioSource _spikes_sound;
    private bool _active = false;

    private void Awake()
    {
      _gameModel = GameObject.FindObjectOfType<GameModel>();
      _spikes_sound = gameObject.GetComponent<AudioSource>();
      SetInactive();
    }

    private void SetActive()
    {
      _active = true;
      Invoke("SetInactive", period);
      _spikes_sound.Play();
    }

    private void SetInactive()
    {
      _active = false;
      Invoke("SetActive", period);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (_active && other.CompareTag("Player"))
      {
        _gameModel.Lost();
      }
    }
  }
}