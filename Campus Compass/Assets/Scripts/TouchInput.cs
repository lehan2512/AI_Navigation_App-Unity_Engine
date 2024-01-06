using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public float scrollSpeed = 5f;

    private RectTransform content;
    private RectTransform viewport;

    private bool isDragging = false;

    void Start()
    {
        // Get the RectTransform components for the content and viewport
        content = GetComponent<ScrollRect>().content;
        viewport = GetComponent<ScrollRect>().viewport;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            // Ensure that only vertical scrolling occurs
            float deltaX = 0f;
            float deltaY = eventData.delta.y;

            // Calculate the minY and maxY values dynamically based on content and viewport size
            float minY = 0f;
            float maxY = content.rect.height - viewport.rect.height;

            // Scroll the content based on the inverted drag delta and scroll speed
            Vector2 newPosition = content.anchoredPosition - new Vector2(deltaX * scrollSpeed, deltaY * scrollSpeed);

            // Clamp the Y position within the specified range
            newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

            // Apply the new position to the content, keeping X position constant
            content.anchoredPosition = new Vector2(content.anchoredPosition.x, newPosition.y);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
    }
}
