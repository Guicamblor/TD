using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildingSpawner buildManager;

    void Start()
    {
        buildManager = BuildingSpawner.instance; 
    }
    public void PegarTorre()
    {
        Debug.Log("Peguei essa torre");
        buildManager.EscolherTorreParaComprar(buildManager.PrefabDaTorre);
    }
    public void PegueOutraTorre()
    {
        Debug.Log("Outra Torre foi pega");
        buildManager.EscolherTorreParaComprar(buildManager.OutraTorre);
    }
}
