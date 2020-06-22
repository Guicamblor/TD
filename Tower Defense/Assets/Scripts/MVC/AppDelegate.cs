using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppDelegate : MonoBehaviour
{
    [SerializeField] SceneWireframe _wireframe;
    [SerializeField] InspectorViewControllerFactory _factory;

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        Init();
    }

    private void Init()
    {
        new GameInitializer(_wireframe, _factory).Init();
    }
}
