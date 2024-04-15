using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject leaderboard;
    public GameObject developers;
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
    public void LeaderboardExit()
    {
        menu.SetActive(true);
    }
    public void Developers()
    {
        developers.SetActive(true);
    }
    public void ExitDevelopers()
    {
        developers.SetActive(false);
    }
}
