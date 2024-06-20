using UnityEngine;
using UnityEngine.SceneManagement;

public class PathMenu : MonoBehaviour
{

    public void PlayPath1()
    {
        SceneManager.LoadScene("Path1Puzzle1");
    }

    public void PlayPath2() 
    {
        SceneManager.LoadScene("Path2Puzzle1");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
