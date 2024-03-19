using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadPlayer : MonoBehaviour
{
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject deadScreen;
    void Update()
    {
        if (DestroyApple.countyy == 3)
        {
            Lvl1.SetActive(false);
        }
        else if (DestroyApple.countyy == 2)
        {
            Lvl2.SetActive(false);
        }
        else if(DestroyApple.countyy == 1)
        {
            Lvl3.SetActive(false);
            Debug.Log("You Deaddd");
            deadScreen.SetActive(true);
            DestroyApple.countyy = 4;
            Time.timeScale = 0;
        }
        
    }
}
