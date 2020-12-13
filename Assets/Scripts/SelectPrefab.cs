using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPrefab : MonoBehaviour
{
    [SerializeField] private List<GameObject> carModels = new List<GameObject>();
    public ObjectScroll objectScroll;
    private  int carIndex;

    private void Start()
    {
        carModels[0].SetActive(true);
        for (int i = 1; i <= carModels.Count - 1; i++)
        {
            carModels[i].SetActive(false);
        }
    }

    public void SelectPrefabButton()
    {
        for (int i = 0; i <= carModels.Count-1; i++)
        {
            if(objectScroll.currentIndex == i)
            {  
                carIndex = i;
            }
            carModels[i].SetActive(false);
        }
        carModels[carIndex].SetActive(true);
    }

}
