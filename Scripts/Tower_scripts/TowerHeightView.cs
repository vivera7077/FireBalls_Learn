using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerHeightView : MonoBehaviour
{
    [SerializeField] private TMP_Text _size;
    [SerializeField] private Tower_Controller _tower;

    private void OnEnable()
    {
        _tower.SizeUpdated += OnSizeUpdated;
    }

    private void OnDisable()
    {
        _tower.SizeUpdated -= OnSizeUpdated;
    }
    private void OnSizeUpdated(int size)
    {
        _size.text = size.ToString();
    }
}
