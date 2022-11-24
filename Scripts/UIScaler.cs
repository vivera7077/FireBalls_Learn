using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScaler : MonoBehaviour
{
    [SerializeField] private RectTransform _handPanel;
    private float _targetWidth = 1440f;
    private float _targetHeight = 2560f;

    void Start()
    {
        SetIndicatorScale();
    }

    private void SetIndicatorScale()
    {
        float scaleX = Mathf.Clamp((float)Screen.width / _targetWidth, 0.5f, 1f);

        float scaleY = Mathf.Clamp((float)Screen.height / _targetHeight, 0.5f, 1f);

        _handPanel.sizeDelta = new Vector2(100f * scaleX, 100f * scaleY);
    }
}
