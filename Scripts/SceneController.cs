using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
