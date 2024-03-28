using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DestroyApple : MonoBehaviour
{
    public GameObject Apple;
    public static int countLive = 4;
    public static float scorePlayer = 0;
    public static float seriesOfPoint = 1;// очков за уровень
    public static int lvlScoreStart = 0;//Уровень множителя
    public static int lvlScoreEnd = 1;//Уровень множителя уровновешиватель
    public static int intermediateValue = 0;//счёт очков по уровням, значение сбрасывается при -1 ед, максималка 20
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Destroy(Apple);
            //print("- 1 жизнь");
            CountyScoreMinus();
            countLive -= 1;
        }
        else if (collision.CompareTag("Player"))
        {
            Destroy(Apple);
            //print("+ 1 жизнь");
            CountyScorePlus();
        }
    }

    public void CountyScorePlus() //логика для подсчёта очков
    {
        if (lvlScoreStart == lvlScoreEnd)
        {
            seriesOfPoint *= 2;
            lvlScoreEnd += 1;
            print("улучшили кол-во очков за уровень");
        }
        intermediateValue += 1;
        print(intermediateValue);
        if (intermediateValue == 5)
        {
            intermediateValue = 0;
            lvlScoreStart += 1;
            print("улучшили уровень");
        }
        scorePlayer += seriesOfPoint;
        print(scorePlayer + " point");
    }
    public void CountyScoreMinus()
    {
        intermediateValue = 0;
        lvlScoreEnd -= 1;
        lvlScoreStart -= 1;
        seriesOfPoint /= 2;
        if (seriesOfPoint < 1)
        {
            seriesOfPoint = 1;
        }
    }

}

