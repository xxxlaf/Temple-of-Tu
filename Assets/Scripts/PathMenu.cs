using UnityEngine;
using UnityEngine.SceneManagement;

public class PathMenu : MonoBehaviour
{
    [SerializeField]
    AudioManager AudioManager;

    public void PlayPath1()
    {
        Click();
        SceneManager.LoadScene("Path1Puzzle1");
    }

    public void PlayPath2() 
    {
        Click();
        SceneManager.LoadScene("Path2Puzzle1");
    }

    public void GoToMainMenu()
    {
        Click();
        SceneManager.LoadScene("MainMenu");
    }

    private void Click()
    {
        if (AudioManager != null)
        {
            AudioManager.PlayClickNoise();
        }
    }
}
