using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ImageClickHandler : MonoBehaviour, IPointerClickHandler
{
    public SpawnerHandler spawnerHandler;

    public void OnPointerClick(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        Vector2 localPoint;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out localPoint))
        {
            // Normalize the localPoint to [-1, 1]
            float normalizedX = (localPoint.x / rectTransform.rect.width) * 2;
            float normalizedY = (localPoint.y / rectTransform.rect.height) * 2;
            Vector2 normalizedPoint = new Vector2(normalizedX, normalizedY);

            spawnerHandler.PlaceSphere(normalizedPoint);
        }
    }
}