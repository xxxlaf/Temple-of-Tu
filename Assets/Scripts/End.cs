using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    [SerializeField]
    AudioManager AudioManager;

    public void MainMenu()
    {
        Click();
        SceneManager.LoadScene("MainMenu");
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
