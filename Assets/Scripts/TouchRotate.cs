using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    float number;
    float[] Rotation = new float[] {-90f,90f,180f };
    public static bool levelCleared;
    public GameControl gameControl;
    public bool isSolved = false;

    private void Start() 
    {
        RandomizePuzzle();
    }

    public void RandomizePuzzle()
    {
        number = Rotation[Random.Range(0, Rotation.Length)];
        transform.Rotate(0f, 0f, number);
    }

    public void OnMouseDown() 
    {
        if (gameControl.unsolvedpices != 0)
        {
            transform.Rotate(0f, 0f, 90f);
            print(transform.eulerAngles.z);
            if (transform.localRotation.z >= -0.001f && transform.localRotation.z <= 0.001f)
            {
                gameControl.unsolvedpices--;
                isSolved = true;
            }
            else
            {
                if (isSolved)
                {
                    isSolved = false;
                    gameControl.unsolvedpices++;
                }
            }
        }   
    }
}
