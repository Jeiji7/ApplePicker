using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScorePoint : MonoBehaviour
{
    public static int scorePlayer = 0;
    public static int seriesOfPoint = 1;// ����� �� �������
    public static int lvlScoreStart = 0;//������� ���������
    public static int lvlScoreEnd = 1;//������� ��������� ����������������
    public static int intermediateValue = 0;//���� ����� �� �������, �������� ������������ ��� -1 ��, ���������� 20
  

    public void CountyScore(int question) //������ ��� �������� �����
    {
        seriesOfPoint = question;
        if (lvlScoreStart == lvlScoreEnd)
        {
            seriesOfPoint *= 2;
            lvlScoreEnd += 1;
            print("�������� ���-�� ����� �� �������");
        }
        intermediateValue += 1;
        print(intermediateValue);
        if (intermediateValue == 5)
        {
            intermediateValue = 0;
            lvlScoreStart += 1;
            print("�������� �������");
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
