using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject leaderboard;
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
   
    public void Leaderboard()
    {
        menu.SetActive(false);
    }
}
