using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesPlayer : MonoBehaviour
{
    public static int countLive = 4;
    public static float scorePlayer;
    public static float seriesOfPoint;// ����� �� �������
    public static int lvlScoreStart;//������� ���������
    public static int lvlScoreEnd;//������� ��������� ����������������
    public static int intermediateValue;//���� ����� �� �������, �������� ������������ ��� -1 ��, ���������� 20
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
