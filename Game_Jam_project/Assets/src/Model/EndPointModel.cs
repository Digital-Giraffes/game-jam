using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPointModel : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      // Победа
    }
  }
}
