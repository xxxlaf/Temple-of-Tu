using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot2 : MonoBehaviour, IDropHandler
{
    public DragScript2 CurrentSymbol;

    [SerializeField]
    private Path2Puzzle3Manager _pm;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            CurrentSymbol = eventData.pointerDrag.GetComponent<DragScript2>();
            _pm.CheckPuzzleState();
        }
    }
}
