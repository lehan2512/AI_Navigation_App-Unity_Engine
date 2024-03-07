using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour, IDragHandler
{
    public float scrollSpeed = 10.0f;

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
        // Get the drag delta only in the horizontal direction
        float deltaX = eventData.delta.x;

        // Calculate the minX and maxX values dynamically based on content and viewport size
        float minX = 0f;
        float maxX = content.rect.width - viewport.rect.width;

        // Scroll the content based on the inverted drag delta and scroll speed
        Vector2 newPosition = content.anchoredPosition - new Vector2(deltaX * scrollSpeed, 0);

        // Clamp the X position within the specified range
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Apply the new position to the content
        content.anchoredPosition = newPosition;
    }


}
