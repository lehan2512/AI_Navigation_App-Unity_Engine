using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour, IDragHandler
{
    public float scrollSpeed = 1.0f;

    private RectTransform content;
    private RectTransform viewport;

    void Start()
    {
        // Get the RectTransform components for the content and viewport
        content = GetComponent<ScrollRect>().content;
        viewport = GetComponent<ScrollRect>().viewport;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Set the drag delta to zero for horizontal movement
        float deltaX = 0f;

        // Get the drag delta only in the vertical direction
        float deltaY = eventData.delta.y;

        // Calculate the minY and maxY values dynamically based on content and viewport size
        float minY = 0f;
        float maxY = content.rect.height - viewport.rect.height;

        // Scroll the content based on the inverted drag delta and scroll speed
        Vector2 newPosition = content.anchoredPosition - new Vector2(deltaX * scrollSpeed, deltaY * scrollSpeed);

        // Clamp the Y position within the specified range
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Keep the x-coordinates constant
        newPosition.x = content.anchoredPosition.x;

        // Apply the new position to the content
        content.anchoredPosition = newPosition;
    }
}
