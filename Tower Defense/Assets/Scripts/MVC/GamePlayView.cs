using System;
using UnityEngine;

public class GamePlayView : View
{
    public void Setup(GameManager gameManager, Action gameOverViewUpdate)
    {
        gameManager.Setup(gameOverViewUpdate);
    }

}