using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public DragScript CurrentSymbol;

    [SerializeField]
    private Path1PuzzleManager3 _pm;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            CurrentSymbol = eventData.pointerDrag.GetComponent<DragScript>();
            _pm.CheckPuzzleState();
        }
    }
}
