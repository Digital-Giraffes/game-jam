using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
  public class PlayerView : MonoBehaviour
  {
    public void Walking(Vector3 delta_position)
    {
      gameObject.transform.position += delta_position;
    }
    private void SetPosition(Vector3 new_position)
    {
      gameObject.transform.position = new_position;
    }
  }
}
