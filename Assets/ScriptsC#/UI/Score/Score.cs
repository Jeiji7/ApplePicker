using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text uiTextScore;
    void Start()
    {
        uiTextScore.text = $"¬аш счЄт: {StatesPlayer.scorePlayer}";
    }

    void Update()
    {
        uiTextScore.text = $"¬аш счЄт: {StatesPlayer.scorePlayer}";
    }
}
