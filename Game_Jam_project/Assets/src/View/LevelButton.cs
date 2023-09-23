using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace src.View
{
  public class LevelButton : MonoBehaviour
  {
    public int levelNum;
    public TMP_Text text;
    void Start()
    {
      text.text = "Level " + levelNum;
    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}
