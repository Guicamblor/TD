using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    private GameObject torreParaBuildar;

    public static BuildingSpawner instance;

    public GameObject PrefabDaTorre;

    public GameObject OutraTorre;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("Falta o BuildingSPawner");
            return;
        }
        instance = this;
    }
    
    public GameObject PegarTorre()
    {
        return torreParaBuildar;
    }
    public void EscolherTorreParaComprar(GameObject torre)
    {
        torreParaBuildar = torre;
    }
}
