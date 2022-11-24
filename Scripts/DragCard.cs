using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragCard : MonoBehaviour, IBeginDragHandler, IPointerDownHandler, IEndDragHandler, IDragHandler
{
    private Canvas _canvas;
    private RectTransform _rectTransform;


    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _canvas = GetComponentInParent<Canvas>();
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeingDrag");
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

       _rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        //Destroy(gameObject);
        Debug.Log("OnEndDrag");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    

    //void DraggingCard()
    //{
    //    float _offset = 1;
    //    Vector2 _position = Camera.main.WorldToViewportPoint(Input.mousePosition);
    //    float maxPosX = Screen.width - _offset;
    //    float maxPosY = Screen.height - _offset;

    //    float positionX = Mathf.Clamp(_position.x, 0, maxPosX);
    //    float positionY = Mathf.Clamp(_position.y, 0, maxPosY);

    //    _rectTransform.anchoredPosition = new Vector2(positionX, positionY); 
    //}
}
