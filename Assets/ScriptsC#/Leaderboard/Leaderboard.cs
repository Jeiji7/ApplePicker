using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public GameObject itemPrefab; // ������ �������� ������
    public Transform contentPanel; // ������, ���������� ��������
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        UpdateListView();
    }

    private void Update()
    {
        scoreManager = GetComponent<ScoreManager>();
        UpdateListView();
    }

    public void UpdateListView()
    {
        // �������� ������ �������� ������
        foreach (Transform child in contentPanel)
        {
            Destroy(child.gameObject);
        }

        // �������� ������ ���������� �� ScoreManager
        float[] topScores = scoreManager.topScores;

        // ������� ����� �������� ������ ��� ������ �����������
        for (int i = 0; i < topScores.Length; i++)
        {
            if (topScores[i] > 0)
            {
                CreateListItem(i + 1, topScores[i]);
            }
        }
    }
    void CreateListItem(int rank, float score)
    {
        // ������� ����� ������� ������
        GameObject newItem = Instantiate(itemPrefab, contentPanel);

        // ���������� ����� ��������
        TMP_Text[] texts = newItem.GetComponentsInChildren<TMP_Text>();
        texts[0].text = rank.ToString(); // ����� ����������
        texts[1].text = score.ToString(); // ���������� �����
    }
}

