using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public static int score;
    public static int hiScore;
    
    public static void NewGame()
    {
        score = 0;
        hiScore = PlayerPrefs.GetInt("HiScore");
        SceneManager.LoadScene("Game");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void GameOver()
    {
        if (score > hiScore)
        {
            hiScore = score;
            PlayerPrefs.SetInt("HiScore", hiScore);
        }
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
