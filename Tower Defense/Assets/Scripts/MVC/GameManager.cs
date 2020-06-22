using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Action _gameOverViewUpdate;

    //public (nome do script de vida) vida;

    void Update()
    {

        /*if (vida <= 0)
        {
            _gameOverViewUpdate?.Invoke();
            Destroy(gameObject);
        }
        */
    }

    public void Setup(Action gameOverViewUpdate)
    {
        _gameOverViewUpdate = gameOverViewUpdate;
    }
}
