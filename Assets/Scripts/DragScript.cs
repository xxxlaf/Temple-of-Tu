using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField]
    private Canvas canvas;

    private RectTransform _rectTransform;
    private CanvasGroup _canvasGroup;

    [SerializeField]
    AudioManager AudioManager;

    [SerializeField]
    Path1PuzzleManager3 PuzzleManager;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        PlayRockNoise();

        _canvasGroup.alpha = 0.9f;
        _canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        _rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        PlayRockNoise();
        _canvasGroup.alpha = 1f;
        _canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData) { }

    public void PlayRockNoise()
    {
        if (AudioManager != null)
        {
            // have to do this because the puzzle solved audio wouldn't play, because the rock noise took priority
            if (!PuzzleManager.IsPuzzleSolved())
            {
                AudioManager.PlayRockNoise();
            }
        }
    }
}
