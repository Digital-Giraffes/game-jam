using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace view
{
  public class PlayerView : MonoBehaviour
  {
    public void ChangePosition(Vector3 delta_position)
    {
      gameObject.transform.position += delta_position;
      OnPositionChanged();
    }

    // ============================= Callbacks =============================

    private void OnPositionChanged()
    {
      print("new position is: " + gameObject.transform.position);
    }

  }
}
