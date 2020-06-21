using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    public Vector3 posicaoanterior;

    private Color startColor;

    private Renderer rend;

    private GameObject torre;

    BuildingSpawner buildManager;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildingSpawner.instance;
    }

    void OnMouseDown()
    {
      if(buildManager.PegarTorre() == null)
        {
            return;
        }
      if(torre != null)
      {
            Debug.Log("Não pode contruir aqui");
            return;
      }
        GameObject torreParaBuildar = BuildingSpawner.instance.PegarTorre();
        torre = (GameObject)Instantiate(torreParaBuildar, transform.position + posicaoanterior, transform.rotation);
    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.PegarTorre() == null)
            return;
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
