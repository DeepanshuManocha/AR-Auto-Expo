using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandler : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> stars = new List<GameObject>();

    public GameTimer gameTimer; 

    // Update is called once per frame
    void Update()
    {
        if(gameTimer.timer<=25f)
        {
            for(int i=0; i<=stars.Count-1; i++)
            {
                stars[i].SetActive(true);
            }
        }
        if (gameTimer.timer > 25f && gameTimer.timer<=35f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(false);
        }
        if(gameTimer.timer>35f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
        }
    }
}
