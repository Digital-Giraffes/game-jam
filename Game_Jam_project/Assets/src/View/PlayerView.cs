using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
  public class PlayerView : MonoBehaviour
  {
    public void ChangePosition(Vector3 delta_position)
    {
      gameObject.transform.position += delta_position;
    }

    public void SetPosition(Vector3 new_position)
    {
      gameObject.transform.position = new_position;
    }
  }
}
