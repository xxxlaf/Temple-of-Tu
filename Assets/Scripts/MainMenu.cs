using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PathMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
