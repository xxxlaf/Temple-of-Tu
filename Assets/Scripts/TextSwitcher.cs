using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSwitcher : MonoBehaviour
{
    public TMP_Text textComponent;
    public string[] letters;
    public float switchInterval = 1.0f;

    private Coroutine switchCoroutine;

    [SerializeField]
    AudioManager AudioManager;

    private void Start()
    {
        textComponent.text = string.Empty;
    }

    public void StartSwitching()
    {
        if (switchCoroutine != null)
        {
            StopCoroutine(switchCoroutine);
        }
        switchCoroutine = StartCoroutine(SwitchText());
    }

    public void StopSwitching()
    {
        if (switchCoroutine != null)
        {
            StopCoroutine(switchCoroutine);
            switchCoroutine = null;
        }
        textComponent.text = string.Empty;
    }

    private IEnumerator SwitchText()
    {
        for (int i = 0; i < letters.Length; i++)
        {
            textComponent.text = letters[i];

            if (AudioManager != null)
            {
                AudioManager.PlaySymbolSwitch();
            }

            yield return new WaitForSeconds(switchInterval);
        }
        switchCoroutine = null;
    }
}
