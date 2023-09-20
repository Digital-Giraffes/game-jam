using UnityEngine;

namespace model
{
  public class SpikesModel : MonoBehaviour
  {
    private PlayerModel _player_model;

    private void Awake()
    {
      _player_model = GameObject.FindObjectOfType<PlayerModel>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Player")
      {
        _player_model.Lost();
      }
    }
  }
}