using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{

    [SerializeField]
    Text _titleText;

    [SerializeField]
    private Transform _buttonsHolder;

    [SerializeField]
    private ButtonView _buttonViewPrefab;

    public void Setup(string title)
    {
        _titleText.text = title;
    }

    public void AddButton(Action buttonCallback, string labelText)
    {
        var buttonView = Instantiate(_buttonViewPrefab, _buttonsHolder);
        buttonView.Setup(buttonCallback, labelText);
    }
}
