using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public GameTimer gameTimer;
    public List<TouchRotate> touchRotate = new List<TouchRotate>();
    public GameControl gameControl;

   public void ReStartGame()
    {
        gameTimer.timer = 0f;
        gameControl.unsolvedpices = 16;
        foreach(TouchRotate t in touchRotate)
        {
            t.RandomizePuzzle();
        }
        
    }

}
