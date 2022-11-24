using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandPanel : MonoBehaviour
{
    [SerializeField] private GameObject _dragCardPref;
    [SerializeField] private Transform _scrollViewContent;
    [SerializeField] private List<Image> _cards;

    private void Start()
    {
        for (int i = 0; i < _cards.Count; i++)
        {
            var _dragCard = Instantiate(_dragCardPref, _scrollViewContent);
 

        }
    }
}
