using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
  public class UIDoubleBar : MonoBehaviour
  {
    [SerializeField] private Slider _left_bar;
    [SerializeField] private Slider _right_bar;

    private void Awake()
    {
      _left_bar = transform.GetChild(0).GetComponent<Slider>();
      _right_bar = transform.GetChild(1).GetComponent<Slider>();
    }

    public void UpdateValue(float delta)
    {
      _left_bar.value += delta;
      _right_bar.value += delta;
    }

    public void SetMaxValue(float max_value)
    {
      _left_bar.maxValue = max_value;
      _right_bar.maxValue = max_value;
    }

    public void SetValue(float value)
    {
      _left_bar.value = value;
      _right_bar.value = value;
    }
  }
}