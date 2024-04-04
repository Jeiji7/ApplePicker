using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGoldAplle : MonoBehaviour
{
    public GameObject AppleGold;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Destroy(AppleGold);
            CountyScoreMinus();
            StatesPlayer.countLive -= 1;
        }
        else if (collision.CompareTag("Player"))
        {
            Destroy(AppleGold);
            CountyScorePlus();
        }
    }

    public void CountyScorePlus() //логика для подсчёта очков
    {
        if (StatesPlayer.lvlScoreStart == StatesPlayer.lvlScoreEnd)
        {
            StatesPlayer.seriesOfPoint *= 2;
            movePicker.moveTree += 0.5f;
            StatesPlayer.lvlScoreEnd += 1;
            print("улучшили кол-во очков за уровень");
        }
        StatesPlayer.intermediateValue += 1;
        print(StatesPlayer.intermediateValue);
        if (StatesPlayer.intermediateValue == 20)
        {
            StatesPlayer.intermediateValue = 0;
            StatesPlayer.lvlScoreStart += 1;
            print("улучшили уровень");
        }
        StatesPlayer.scorePlayer += StatesPlayer.seriesOfPoint * 20;
        print(StatesPlayer.scorePlayer + " point");
    }
    public void CountyScoreMinus()
    {
        StatesPlayer.intermediateValue = 0;
        StatesPlayer.lvlScoreEnd -= 1;
        StatesPlayer.lvlScoreStart -= 1;
        StatesPlayer.seriesOfPoint /= 2;
        movePicker.moveTree -= 2.3f;
        if (StatesPlayer.seriesOfPoint < 1)
        {
            StatesPlayer.seriesOfPoint = 1;
        }
    }
}
