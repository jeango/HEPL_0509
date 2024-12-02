using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public static int score;
    
    public static void NewGame()
    {
        score = 0;
        SceneManager.LoadScene("Game");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
