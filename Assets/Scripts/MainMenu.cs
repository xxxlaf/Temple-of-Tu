using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    AudioManager AudioManager;

    public void PlayGame()
    {
        Click();
        SceneManager.LoadScene("PathMenu");
    }

    public void QuitGame()
    {
        Click();
        Application.Quit();
    }

    private void Click()
    {
        if (AudioManager != null)
        {
            AudioManager.PlayClickNoise();
        }
    }
}
