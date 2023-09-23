using UnityEngine;
using UnityEngine.PlayerLoop;

namespace model
{
  public class SpikesModel : MonoBehaviour
  {
    public float period;
    private PlayerModel _player_model;
    private AudioSource _spikes_sound;
    private bool _active = false;

    private void Awake()
    {
      _player_model = GameObject.FindObjectOfType<PlayerModel>();
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
      if (_active && other.tag == "Player")
      {
        _player_model.Lost();
      }
    }
  }
}