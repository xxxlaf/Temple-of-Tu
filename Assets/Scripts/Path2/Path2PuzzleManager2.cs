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
    
    private enum PuzzleState
    {
        Unsolved,
        Failed,
        Solved
    }

    private PuzzleState currentState;

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
        currentState = PuzzleState.Unsolved;
    }

    private void UpdatePuzzleState()
    {
        if (IsPuzzleSolved())
        {
            currentState = PuzzleState.Solved;
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
        continueButton.SetActive(true);
        textSwitcher.StopSwitching();
    }

    public void SelectButton(int buttonNumber)
    {
        combinationPressed.Add(buttonNumber);

        int index = combinationPressed.Count - 1;
        if (combinationPressed[index] != combinationSolution[index])
        {
            Debug.Log("Puzzle failed.");
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
        SceneManager.LoadScene("End");
    }
}
