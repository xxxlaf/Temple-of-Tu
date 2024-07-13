using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SymbolBlink : MonoBehaviour
{
    public bool selected;
    public TMP_Text text;
    public Color selectedColor;
    public Color unselectedColor;
    public float fadeDuration;
    public float selectedDuration;

    private Coroutine fadeCoroutine;

    public void Toggle()
    {
        if (fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }

        selected = !selected;
        UpdateColor();

        if (selected)
        {
            fadeCoroutine = StartCoroutine(FadeToUnselectedColor());
        }
    }

    public void UpdateColor()
    {
        if (selected)
        {
            text.color = selectedColor;
        }
        else
        {
            text.color = unselectedColor;
        }
    }

    private IEnumerator FadeToUnselectedColor()
    {
        yield return new WaitForSeconds(selectedDuration);

        float elapsedTime = 0f;
        Color initialColor = text.color;

        while (elapsedTime < fadeDuration)
        {
            text.color = Color.Lerp(initialColor, unselectedColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        text.color = unselectedColor;
        selected = false;
    }
}
