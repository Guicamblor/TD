public class GameInitializer
{
    SceneWireframe _wireframe;
    IViewControllerFactory _factory;

    public GameInitializer(SceneWireframe wireframe, IViewControllerFactory factory)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Init()
    {
        MainMenuViewController viewController = _factory.CreateMainMenuViewController();
        viewController.Setup();
        _wireframe.PresentViewController(viewController);
    }
}
