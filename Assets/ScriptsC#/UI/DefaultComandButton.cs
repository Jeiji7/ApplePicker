using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class DefaulComandButton : MonoBehaviour
{
    public GameObject menu;
    public GameObject score;
    public GameObject dashSlider;
    public static bool pause;
    public GameObject player;
    public GameObject StartGames;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    private void Start()
    {
        pause = false;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Continuos()
    {
        if (DeadPlayer.health != 0)
        {
            menu.SetActive(false);
            pause = false;
            Time.timeScale = 1;
            score.SetActive(true);
            dashSlider.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pause = !pause;
            if (!pause)
            {
                menu.SetActive(false);
                Time.timeScale = 1;
                score.SetActive(true);
                dashSlider.SetActive(true);
            }
            else
            {
                Time.timeScale = 0;
                score.SetActive(false);
                dashSlider.SetActive(false);
                StartGames.SetActive(false);
                menu.SetActive(true);
            }
        }
    }
    public void ExitMenu()
    {
        pause = false;
        print(pause);
        SceneManager.LoadScene("Menu");
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
