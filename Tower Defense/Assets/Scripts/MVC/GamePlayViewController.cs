public class GamePlayViewController : ViewController<GamePlayView>
{
    SceneWireframe _wireframe;
    IViewControllerFactory _factory;

    public GamePlayViewController(GamePlayView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Setup(GameManager gameManager)
    {
        View.Setup(gameManager, GameOver);
    }

    private void GameOver()
    {
        StartGame.EndGame();

        MainMenuViewController viewController = _factory.CreateMainMenuViewController();
        viewController.Setup();
        _wireframe.PresentViewController(viewController);
    }
}
