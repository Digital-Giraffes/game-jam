using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
  public class PlayerView : MonoBehaviour
  {
    [SerializeField] private Image _eye_screen;

    public void ChangePosition(Vector3 delta_position)
    {
      gameObject.transform.position += delta_position;
    }

    public void OpenEyes()
    {
      _eye_screen.enabled = false;
    }

    public void CloseEyes()
    {
      _eye_screen.enabled = true;
    }
  }
}
