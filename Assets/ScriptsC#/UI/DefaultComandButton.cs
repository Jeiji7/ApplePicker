using UnityEngine;
using UnityEngine.SceneManagement;

public class DefaulComandButton : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
