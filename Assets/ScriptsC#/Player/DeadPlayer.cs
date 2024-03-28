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
    public GameObject dashSlider;
    public static int health;

    private void Start()
    {
        health = 1; 
    }
    void Update()
    {
        if (StatesPlayer.countLive == 3)
        {
            Lvl1.SetActive(false);
        }
        else if (StatesPlayer.countLive == 2)
        {
            Lvl2.SetActive(false);
        }
        else if(StatesPlayer.countLive == 1)
        {
            Lvl3.SetActive(false);
            Debug.Log("You Deaddd");
            ScoreeScreen.SetActive(false);
            dashSlider.SetActive(false);
            deadScreen.SetActive(true);
            health = 0;
            StatesPlayer.countLive = 4;
            StatesPlayer.scorePlayer = 0;
            Time.timeScale = 0;
        }
        
    }
}
