using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameClick : MonoBehaviour
{
    public GameObject Screen;
    private void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Time.timeScale = 1;
            Screen.SetActive(false);
        }
    }
}
