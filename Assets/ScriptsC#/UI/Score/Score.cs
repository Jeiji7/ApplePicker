using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text uiTextScore;
    void Start()
    {
        uiTextScore.text = $"��� ����: {DestroyApple.scorePlayer}";
    }

    void Update()
    {
        uiTextScore.text = $"��� ����: {DestroyApple.scorePlayer}";
    }
}
