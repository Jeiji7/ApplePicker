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
    public GameObject ScoreeScreen;
    void Update()
    {
        if (DestroyApple.countLive == 3)
        {
            Lvl1.SetActive(false);
        }
        else if (DestroyApple.countLive == 2)
        {
            Lvl2.SetActive(false);
        }
        else if(DestroyApple.countLive == 1)
        {
            Lvl3.SetActive(false);
            Debug.Log("You Deaddd");
            deadScreen.SetActive(true);
            ScoreeScreen.SetActive(false);
            DestroyApple.countLive = 4;
            DestroyApple.scorePlayer = 0;
            Time.timeScale = 0;
        }
        
    }
}
