using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_Generator : MonoBehaviour
{
    [SerializeField] private float _towerHeight;
    [SerializeField] private Transform _generatorPoint;
    [SerializeField] private Circle_Script _circle;

    private List<Circle_Script> _circles;

    private void Start()
    {
        //BuildTower();
    }

    public List<Circle_Script> BuildTower()
    {
        _circles = new List<Circle_Script>();

        Transform currentPoint = _generatorPoint;

        for (int i = 0; i < _towerHeight; i++)
        {
            Circle_Script newCircle = BuildCircle(currentPoint);
            _circles.Add(newCircle);
            currentPoint = newCircle.transform;
        }

        return _circles;
    }

    private Circle_Script BuildCircle(Transform currentGeneratorPoint)
    {
        return Instantiate(_circle, GetGeneratorPoint(currentGeneratorPoint), Quaternion.identity, _generatorPoint);
    }

    private Vector3 GetGeneratorPoint(Transform currentCircle)
    {
        return new Vector3(_generatorPoint.position.x, currentCircle.position.y
            + currentCircle.localScale.y / 7.3f,
            _generatorPoint.position.z);
    }
}
