using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesPlayer : MonoBehaviour
{
    public static int countLive = 4;
    public static float scorePlayer;
    public static float seriesOfPoint;// очков за уровень
    public static int lvlScoreStart;//Уровень множителя
    public static int lvlScoreEnd;//Уровень множителя уровновешиватель
    public static int intermediateValue;//счёт очков по уровням, значение сбрасывается при -1 ед, максималка 20
    void Start()
    {
        countLive = 4;
        scorePlayer = 0;
        seriesOfPoint = 1;
        lvlScoreStart = 0;
        lvlScoreEnd = 1;
        intermediateValue = 0;
    }

}
