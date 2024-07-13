using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager instance;
    private bool[] buttonStates;
    public GameObject continueButton;

    private enum PuzzleState
    {
        Unsolved,
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
        buttonStates = new bool[24];
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
        return buttonStates[2] && buttonStates[5] && buttonStates[11] && buttonStates[13] && buttonStates[16] && buttonStates[23]
            && !buttonStates[0] && !buttonStates[1] && !buttonStates[3] && !buttonStates[4] && !buttonStates[6]
            && !buttonStates[7] && !buttonStates[8] && !buttonStates[9] && !buttonStates[10] && !buttonStates[12]
            && !buttonStates[14] && !buttonStates[15] && !buttonStates[17] && !buttonStates[18] && !buttonStates[19]
            && !buttonStates[20] && !buttonStates[21] && !buttonStates[22];
    }

    private void OnPuzzleSolved()
    {
        Debug.Log("Puzzle solved!");
        continueButton.SetActive(true);
    }

    public void SelectButton(int buttonNumber)
    {
        if (buttonNumber < 1 || buttonNumber > 24) return;

        int index = buttonNumber - 1;
        buttonStates[index] = !buttonStates[index];

        UpdatePuzzleState();
    }

    public void Continue()
    {
        SceneManager.LoadScene("Path1Puzzle2");
    }
}
