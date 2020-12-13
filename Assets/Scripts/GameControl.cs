using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pics;

    public GameObject GameOver;

    public int unsolvedpices = 16;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(unsolvedpices == 0)
            GameOver.SetActive(true);
        else
            GameOver.SetActive(false);
    }

    

    

}
