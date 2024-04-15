using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DestroyApple : MonoBehaviour
{
    public GameObject Apple;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            Destroy(Apple);
            //print("- 1 �����");
            CountyScoreMinus();
            StatesPlayer.countLive -= 1;
        }
        else if (collision.CompareTag("Player"))
        {
            Destroy(Apple);
            //print("+ 1 �����");
            CountyScorePlus();
        }
    }

    public void CountyScorePlus() //������ ��� �������� �����
    {
        if (StatesPlayer.lvlScoreStart == StatesPlayer.lvlScoreEnd)
        {
            StatesPlayer.seriesOfPoint *= 2;
            movePicker.moveTree += 0.5f;
            StatesPlayer.lvlScoreEnd += 1;
            print(movePicker.moveTree);
            print("�������� ���-�� ����� �� �������");
        }
        StatesPlayer.intermediateValue += 1;
        print(StatesPlayer.intermediateValue);
        if (StatesPlayer.intermediateValue == 20)
        {
            StatesPlayer.intermediateValue = 0;
            StatesPlayer.lvlScoreStart += 1;
            print("�������� �������");
        }
        StatesPlayer.scorePlayer += StatesPlayer.seriesOfPoint;
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

