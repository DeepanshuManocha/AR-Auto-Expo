using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject fcpColorPallet, vdPlayer, homePannel, introPannel, gamePannel;

    public void OpenFcpPallet()
    {
        fcpColorPallet.SetActive(true);
        vdPlayer.SetActive(false);
    }

    public void OpenVideoPlayer()
    {
        fcpColorPallet.SetActive(false);
        vdPlayer.SetActive(true);
    }

    public void OpenARInstructions()
    {
        introPannel.SetActive(true);
        homePannel.SetActive(false);
        gamePannel.SetActive(false);
    }

    public void OpenGamePannel()
    {
        introPannel.SetActive(false);
        homePannel.SetActive(false);
        gamePannel.SetActive(true);
    }    

    public void BackToHome()
    {
        introPannel.SetActive(false);
        homePannel.SetActive(true);
        gamePannel.SetActive(false);
    }
}
