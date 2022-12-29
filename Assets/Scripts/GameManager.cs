using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameMenu;

    public enum StatusEnum { lose, pause, run }
    public StatusEnum status;

    public void Pause()
    {
        gameMenu.SetActive(true);
        Time.timeScale = 0;

        status = StatusEnum.pause;
    }

    public void Lose()
    {
        Pause();

        status = StatusEnum.lose;
    }

    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }



    public void ClickRun()
    {
        if (status == StatusEnum.lose)
        {
            RestartGame();
        }
        if (status == StatusEnum.lose)
        {
            RunGame();
        }
    }

    public void RestartGame()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        status = StatusEnum.run;
    }

    public void RunGame()
    {
        Time.timeScale = 1;
        status = StatusEnum.run;
    }
}
