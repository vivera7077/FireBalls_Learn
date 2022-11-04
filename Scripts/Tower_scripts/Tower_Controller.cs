 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Tower_Generator))]

public class Tower_Controller : MonoBehaviour
{
    private Tower_Generator _generator;

    private List<Circle_Script> _circles;

    public event UnityAction<int> SizeUpdated;

    private void Start()
    {
        _generator = GetComponent<Tower_Generator>();

        _circles = _generator.BuildTower();

        foreach (var circle in _circles)
        {
            circle.BulletHit += OnBulletHit;
        }
        SizeUpdated?.Invoke(_circles.Count);
    }

    private void OnBulletHit(Circle_Script hitCircle)
    {
        hitCircle.BulletHit -= OnBulletHit;

        _circles.Remove(hitCircle);

        foreach (var circle in _circles)
        {
            circle.transform.position = new Vector3(circle.transform.position.x,
                circle.transform.position.y - circle.transform.localScale.y / 7.3f,
                circle.transform.position.z);
        }

        SizeUpdated?.Invoke(_circles.Count);
    }
}
