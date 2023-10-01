using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.U2D.Animation;

namespace model
{
  public class SpikesModel : MonoBehaviour
  {
    [SerializeReference] private AudioSource spikesExtend;
    [SerializeReference] private AudioSource spikesRetract;
    public float period;
    private GameModel _gameModel;
    private SpriteResolver _resolver;
    private Collider2D _collider;

    private void Awake()
    {
      _gameModel = FindObjectOfType<GameModel>();
      _resolver = gameObject.GetComponent<SpriteResolver>();
      _collider = gameObject.GetComponent<Collider2D>();
      _collider.enabled = false;
      Invoke("SetActive", period); //todo fix callback issue
    }

    private void SetActive()
    {
      _collider.enabled = true;
      _resolver.SetCategoryAndLabel(_resolver.GetCategory(), "Extend");
      Invoke("SetInactive", period);
      spikesExtend.Play();
    }

    private void SetInactive()
    {
      _collider.enabled = false;
      _resolver.SetCategoryAndLabel(_resolver.GetCategory(), "Retract");
      Invoke("SetActive", period);
      spikesRetract.Play();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
      {
        _gameModel.Lost();
      }
    }
  }
}