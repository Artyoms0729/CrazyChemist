using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableColor : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Color color;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Vector3 startPosition;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = rectTransform.position;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rectTransform.position = startPosition;
        canvasGroup.blocksRaycasts = true;
    }
}
