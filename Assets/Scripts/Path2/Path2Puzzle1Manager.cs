using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Path2Puzzle1Manager : MonoBehaviour
{
    public static Path2Puzzle1Manager instance;
    public bool button1Selected;
    public bool button2Selected;
    public bool button3Selected;
    public bool button4Selected;
    public bool button5Selected;
    public bool button6Selected;
    public bool button7Selected;
    public bool button8Selected;
    public bool button9Selected;
    public bool button10Selected;
    public bool button11Selected;
    public bool button12Selected;
    public bool button13Selected;
    public TMP_Text symbol1;
    public TMP_Text symbol2;
    public TMP_Text symbol3;
    public TMP_Text symbol4;
    public TMP_Text symbol5;
    public TMP_Text symbol6;
    public Color glowingColor;
    public GameObject continueButton;

    public void Awake()
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

    public void Start()
    {
        continueButton.SetActive(false);
    }

    public void CheckState()
    {
        // Puzzle Solved
        if (button2Selected && button3Selected && button4Selected && button6Selected && button7Selected && button8Selected
            && (!button1Selected && !button5Selected && !button9Selected && !button10Selected && !button11Selected
            && !button12Selected && !button13Selected))
        {
            Debug.Log("Puzzle solved!");
            IlluminateSymbols();
            continueButton.SetActive(true);
        }
    }

    public void SelectButton(int buttonNumber)
    {
        switch (buttonNumber)
        {
            case 1:
                if (button1Selected) button1Selected = false;
                else button1Selected = true;
                break;
            case 2:
                if (button2Selected) button2Selected = false;
                else button2Selected = true;
                break;
            case 3:
                if (button3Selected) button3Selected = false;
                else button3Selected = true;
                break;
            case 4:
                if (button4Selected) button4Selected = false;
                else button4Selected = true;
                break;
            case 5:
                if (button5Selected) button5Selected = false;
                else button5Selected = true;
                break;
            case 6:
                if (button6Selected) button6Selected = false;
                else button6Selected = true;
                break;
            case 7:
                if (button7Selected) button7Selected = false;
                else button7Selected = true;
                break;
            case 8:
                if (button8Selected) button8Selected = false;
                else button8Selected = true;
                break;
            case 9:
                if (button9Selected) button9Selected = false;
                else button9Selected = true;
                break;
            case 10:
                if (button10Selected) button10Selected = false;
                else button10Selected = true;
                break;
            case 11:
                if (button11Selected) button11Selected = false;
                else button11Selected = true;
                break;
            case 12:
                if (button12Selected) button12Selected = false;
                else button12Selected = true;
                break;
            case 13:
                if (button13Selected) button13Selected = false;
                else button13Selected = true;
                break;
        }

        CheckState();
    }

    public void IlluminateSymbols()
    {
        symbol1.color = glowingColor;
        symbol2.color = glowingColor;
        symbol3.color = glowingColor;
        symbol4.color = glowingColor;
        symbol5.color = glowingColor;
        symbol6.color = glowingColor;
    }

    public void Continue()
    {
        SceneManager.LoadScene("Path2Puzzle2");
    }
}
