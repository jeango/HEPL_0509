using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        GameManager.NewGame();
    }

    public void OnOptionsButton()
    {
        
    }

    public void OnQuitButton()
    {
        GameManager.QuitGame();
    }

    public void OnMenuButton()
    {
        GameManager.LoadMainMenu();
    }
}