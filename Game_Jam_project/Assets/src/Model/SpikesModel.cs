using UnityEngine;
using UnityEngine.PlayerLoop;

namespace model
{
  public class SpikesModel : MonoBehaviour
  {
    public float period;
    private PlayerModel _player_model;
    private AudioSource _spikes_sound;
    private float _time = 0;
    private bool _active = false;

    private void Awake()
    {
      _player_model = GameObject.FindObjectOfType<PlayerModel>();
      _spikes_sound = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
      _time += Time.deltaTime;
      if (_time >= period)
      {
        _time = 0;
        _spikes_sound.Play();
        _active = !_active;
      }
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