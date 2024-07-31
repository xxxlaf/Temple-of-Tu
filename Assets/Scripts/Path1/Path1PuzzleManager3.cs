using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Path1PuzzleManager3 : MonoBehaviour
{
    public static Path1PuzzleManager3 instance;
    public GameObject continueButton;
    public ItemSlot[] ItemSlotArray = new ItemSlot[5];
    public List<DragScript> CorrectOrderOfItems;

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
