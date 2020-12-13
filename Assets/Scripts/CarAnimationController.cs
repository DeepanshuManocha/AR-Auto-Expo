using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimationController : MonoBehaviour
{
    private bool isOpend;
    public Animator anim;

    private void Start()
    {
        isOpend = false;
    }
    public void GateAnimation()
    { 
        if(!isOpend)
        {
            anim.SetBool("isOpened", false);
            isOpend = true;
        }
        else
        {
            anim.SetBool("isOpened", true);
            isOpend = false;
        }
    }
}
