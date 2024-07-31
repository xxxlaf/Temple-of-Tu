using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Path2Puzzle3Manager : MonoBehaviour
{
    public static Path2Puzzle3Manager instance;
    public GameObject continueButton;
    public ItemSlot2[] ItemSlotArray = new ItemSlot2[5];
    public List<DragScript2> CorrectOrderOfItems;

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

    public void CheckPuzzleState()
    {
        if (IsPuzzleSolved())
        {
            OnPuzzleSolved();
        }
    }

    public bool IsPuzzleSolved()
    {
        for (int i = 0; i < ItemSlotArray.Length; i++)
        {
            if (ItemSlotArray[i] == null)
            {
                return false;
            }

            if (ItemSlotArray[i].CurrentSymbol != CorrectOrderOfItems[i])
            {
                return false;
            }
        }

        return true;
    }

    private void OnPuzzleSolved()
    {
        if (AudioManager != null)
        {
            AudioManager.PlayPuzzleSuccessNoise();
        }

        continueButton.SetActive(true);
    }

    public void Continue()
    {
        if (AudioManager != null)
        {
            AudioManager.PlayClickNoise();
        }

        SceneManager.LoadScene("End");
    }
}
