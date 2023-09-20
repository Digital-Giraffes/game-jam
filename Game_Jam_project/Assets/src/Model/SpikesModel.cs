using UnityEngine;

namespace model
{
  public class SpikesModel : MonoBehaviour
  {
    private PlayerModel _player_model;
    private AudioSource _spikes_sound;

    private void Awake()
    {
      _player_model = GameObject.FindObjectOfType<PlayerModel>();
      _spikes_sound = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Player")
      {
        _spikes_sound.Play();
        _player_model.Lost();
      }
    }
  }
}