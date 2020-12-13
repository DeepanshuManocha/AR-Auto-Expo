using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScroll : MonoBehaviour
{
    [SerializeField] private List<GameObject> miniCarModels= new List<GameObject>();
    public int currentIndex;
    private int lastIndex;

    private void Start()
    {
        currentIndex = 0;
        lastIndex = miniCarModels.Count - 1;

        miniCarModels[0].SetActive(true);
        for (int i=1; i <= lastIndex; i++)
        {
            miniCarModels[i].SetActive(false);
        }
    }

    public void RightScrollButton()
    {
        if(currentIndex >= 0 && currentIndex < lastIndex)
        {
            currentIndex++;
            for (int i = 0; i <= lastIndex; i++)
            {
                miniCarModels[i].SetActive(false);
            }
            miniCarModels[currentIndex].SetActive(true);
        }
       
    }

    public void LeftScrollButton()
    {
        if (currentIndex > 0 && currentIndex <= lastIndex)
        {
            currentIndex--;
            for (int i = 0; i <= lastIndex; i++)
            {
                miniCarModels[i].SetActive(false);
            }
            miniCarModels[currentIndex].SetActive(true);
        }
    }
}
