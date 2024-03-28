using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScorePoint : MonoBehaviour
{
    public static int scorePlayer = 0;
    public static int seriesOfPoint = 1;// очков за уровень
    public static int lvlScoreStart = 0;//Уровень множителя
    public static int lvlScoreEnd = 1;//Уровень множителя уровновешиватель
    public static int intermediateValue = 0;//счёт очков по уровням, значение сбрасывается при -1 ед, максималка 20
  

    public void CountyScore(int question) //логика для подсчёта очков
    {
        seriesOfPoint = question;
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
        if (seriesOfPoint < 0)
        {
            intermediateValue = 0;
            lvlScoreStart -= 1;
            lvlScoreEnd -= 1;
        }
        else
        {
            scorePlayer += seriesOfPoint;
            print(scorePlayer + " point");
        }

    }
}
