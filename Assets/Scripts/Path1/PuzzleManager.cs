using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager instance;
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
    public bool button14Selected;
    public bool button15Selected;
    public bool button16Selected;
    public bool button17Selected;
    public bool button18Selected;
    public bool button19Selected;
    public bool button20Selected;
    public bool button21Selected;
    public bool button22Selected;
    public bool button23Selected;
    public bool button24Selected;
    public GameObject puzzleSolvedText;

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
        puzzleSolvedText.SetActive(false);
    }

    public void CheckState()
    {
        // Puzzle Solved
        if (button3Selected && button6Selected && button12Selected && button14Selected && button17Selected && button24Selected
            && (!button1Selected && !button2Selected && !button4Selected && !button5Selected && !button7Selected
            && !button8Selected && !button9Selected && !button10Selected && !button11Selected && !button13Selected
            && !button15Selected && !button16Selected && !button18Selected && !button19Selected && !button20Selected
            && !button21Selected && !button22Selected && !button23Selected))
        {
            Debug.Log("Puzzle solved!");
            puzzleSolvedText.SetActive(true);
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
            case 14:
                if (button14Selected) button14Selected = false;
                else button14Selected = true;
                break;
            case 15:
                if (button15Selected) button15Selected = false;
                else button15Selected = true;
                break;
            case 16:
                if (button16Selected) button16Selected = false;
                else button16Selected = true;
                break;
            case 17:
                if (button17Selected) button17Selected = false;
                else button17Selected = true;
                break;
            case 18:
                if (button18Selected) button18Selected = false;
                else button18Selected = true;
                break;
            case 19:
                if (button19Selected) button19Selected = false;
                else button19Selected = true;
                break;
            case 20:
                if (button20Selected) button20Selected = false;
                else button20Selected = true;
                break;
            case 21:
                if (button21Selected) button21Selected = false;
                else button21Selected = true;
                break;
            case 22:
                if (button22Selected) button22Selected = false;
                else button22Selected = true;
                break;
            case 23:
                if (button23Selected) button23Selected = false;
                else button23Selected = true;
                break;
            case 24:
                if (button24Selected) button24Selected = false;
                else button24Selected = true;
                break;
        }

        CheckState();
    }
}
