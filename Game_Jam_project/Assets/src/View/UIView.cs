using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace view
{
  public class UIView : MonoBehaviour
  {

    // ============================= Singleton =============================

    private UIView() { }
    private static readonly Lazy<UIView> lazy = new Lazy<UIView>(() => new UIView());
    public static UIView Instance
    {
      get
      {
        return lazy.Value;
      }
    }

    // =============================== Body ===============================

    [SerializeField] private Image _eye_screen;
    [SerializeField] private UIDoubleBar _eye_bar;

    public void OpenEyes()
    {
      _eye_screen.enabled = false;
    }

    public void CloseEyes()
    {
      _eye_screen.enabled = true;
    }

    public void UpdateEyeBar(float delta)
    {
      _eye_bar.UpdateValue(delta);
    }

    public void Configure(float max_eyes_time)
    {
      _eye_bar.SetMaxValue(max_eyes_time);
      _eye_bar.SetValue(max_eyes_time);
    }


  }
}
