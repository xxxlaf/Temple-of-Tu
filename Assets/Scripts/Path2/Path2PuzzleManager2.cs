using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Path2PuzzleManager2 : MonoBehaviour
{
    public static Path2PuzzleManager2 instance;
    public GameObject continueButton;
    private List<int> combinationPressed = new List<int>();
    private List<int> combinationSolution = new List<int> { 2, 5, 10, 5, 2, 3, 1, 6 };
    public TextSwitcher textSwitcher;

    [SerializeField]
    AudioManager AudioManager;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        continueButton.SetActive(false);
    }

    private void UpdatePuzzleState()
    {
        if (IsPuzzleSolved())
        {
            OnPuzzleSolved();
        }
    }

    private bool IsPuzzleSolved()
    {
        if (combinationPressed.Count != combinationSolution.Count)
            return false;

        for (int i = 0; i < combinationPressed.Count; i++)
        {
            if (combinationPressed[i] != combinationSolution[i])
                return false;
        }
        
        return true;
    }

    private void OnPuzzleSolved()
    {
        Debug.Log("Puzzle solved!");

        if (AudioManager != null)
        {
            AudioManager.PlayPuzzleSuccessNoise();
        }

        continueButton.SetActive(true);
        textSwitcher.StopSwitching();
    }

    public void SelectButton(int buttonNumber)
    {
        if (AudioManager != null)
        {
            AudioManager.PlaySymbolClickNoise();
        }

        combinationPressed.Add(buttonNumber);

        int index = combinationPressed.Count - 1;
        if (combinationPressed[index] != combinationSolution[index])
        {
            if (AudioManager != null)
            {
                AudioManager.PlayFailedNoise();
            }

            combinationPressed.Clear();
            textSwitcher.StopSwitching();
        }
        else
        {
            Debug.Log("Good!");
        }

        UpdatePuzzleState();
    }

    public void Continue()
    {
        if (AudioManager != null)
        {
            AudioManager.PlayClickNoise();
        }

        SceneManager.LoadScene("Path2Puzzle3");
    }
}
