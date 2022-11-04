using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Gun_Script : MonoBehaviour
{
    [SerializeField] private Bullet_script _bullet;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Circle_Script _circle;
    [SerializeField] private float _shootingDelay;
    [SerializeField] private float _pushDistance;

    private Rigidbody _rb;
    private float _timeAfterShoot;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        _timeAfterShoot += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (_timeAfterShoot >= _shootingDelay)
            {
                Shoot();
                transform.DOMoveX(transform.position.x + _pushDistance, _shootingDelay / 2).SetLoops(2, LoopType.Yoyo);
                _timeAfterShoot = 0;
            }
        }
    }

    private void Shoot()
    {
        Instantiate(_bullet, _shootPoint.position, Quaternion.identity);
    }

}
