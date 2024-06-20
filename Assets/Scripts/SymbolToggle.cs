using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SymbolToggle : MonoBehaviour
{
    public bool selected;
    public TMP_Text text;
    public Color selectedColor;
    public Color unselectedColor;

    public void Toggle()
    {
        if (selected) selected = false;
        else selected = true;
        UpdateColor();
    }

    public void UpdateColor()
    {
        if (selected) text.color = selectedColor;
        else text.color = unselectedColor;
    }
}
