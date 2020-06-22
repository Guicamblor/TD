using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Action _gameOverViewUpdate;

    private Vida vida;
    public GameObject end;

    void Update()
    {
        vida = end.GetComponent<Vida>();

        if (vida.vida <= 0)
        {
            _gameOverViewUpdate?.Invoke();
            Destroy(gameObject);
        }
    }

    public void Setup(Action gameOverViewUpdate)
    {
        _gameOverViewUpdate = gameOverViewUpdate;
    }
}