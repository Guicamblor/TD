using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    Action _buttonCallback;

    [SerializeField]
    private Text _labelText;

    public void Setup(Action buttonCallback, string labelText)
    {
        _buttonCallback = buttonCallback;
        _labelText.text = labelText;
    }

    public void OnClick()
    {
        _buttonCallback?.Invoke();
    }
}
