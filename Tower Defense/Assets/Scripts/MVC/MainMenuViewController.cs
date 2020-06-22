using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
    SceneWireframe _wireframe;
    IViewControllerFactory _factory;

    public MainMenuViewController(MainMenuView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Setup()
    {
        View.Setup(Application.productName);

        View.AddButton(PlayGame, "Jogar");
        View.AddButton(ShowSettingsMenu, "Configurações");
        View.AddButton(QuitGame, "Sair");

    }

    private void PlayGame()
    {
        Debug.Log("Playing game");

        GameManager gameManager = StartGame.BeginGame();

        var viewController = _factory.CreateGamePlayViewController();
        viewController.Setup(gameManager);

        _wireframe.PresentViewController(viewController);
    }

    private void ShowSettingsMenu()
    {
        var viewController = _factory.CreateSettingsMenuViewController();
        viewController.Setup(() =>
        {
            viewController.Dismiss();
        });

        viewController.View.transform.SetParent(View.transform, false);
    }

    private void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
