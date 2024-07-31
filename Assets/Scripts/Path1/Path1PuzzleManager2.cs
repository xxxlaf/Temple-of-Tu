using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Path1PuzzleManager2 : MonoBehaviour
{
    public static Path1PuzzleManager2 instance;
    public GameObject continueButton;
    private List<int> combinationPressed = new List<int>();
    private List<int> combinationSolution = new List<int> { 1, 10, 5, 11, 2, 9, 4, 5 };
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

        UpdatePuzzleState();
    }

    public void Continue()
    {
        if (AudioManager != null)
        {
            AudioManager.PlayClickNoise();
        }

        SceneManager.LoadScene("Path1Puzzle3");
    }
}
