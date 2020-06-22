using UnityEngine;

public class InspectorViewControllerFactory : MonoBehaviour, IViewControllerFactory
{
    [SerializeField]
    SceneWireframe _wireframe;

    [Header("Prefabs")]

    [SerializeField]
    MainMenuView _mainMenuViewPrefab;

    [SerializeField]
    SettingsMenuView _settingsMenuViewPrefab;

    [SerializeField]
    GamePlayView _gamePlayViewPrefab;

    public MainMenuViewController CreateMainMenuViewController()
    {
        var mainMenuView = Instantiate(_mainMenuViewPrefab);
        return new MainMenuViewController(mainMenuView, _wireframe, this);
    }

    public SettingsMenuViewController CreateSettingsMenuViewController()
    {
        var settingsMenuView = Instantiate(_settingsMenuViewPrefab);
        return new SettingsMenuViewController(settingsMenuView);
    }
    
    public GamePlayViewController CreateGamePlayViewController()
    {
        var gamePlayView = Instantiate(_gamePlayViewPrefab);
        return new GamePlayViewController(gamePlayView, _wireframe, this);
    }
}