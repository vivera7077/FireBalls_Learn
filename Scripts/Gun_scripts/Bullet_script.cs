using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_script : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;

    private Vector3 _shootDir;

    private void Start()
    {
        _shootDir = Vector3.left;
    }

    private void Update()
    {
        transform.Translate(_shootDir * _bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Circle_Script circle))
        {
            circle.Break();
            Destroy(gameObject);
        }

        if (other.TryGetComponent(out BarrierDetector barrier))
        {
            Bounce();
        }
    }

    private void Bounce()
    {
        _shootDir = Vector3.right + Vector3.up*2;
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
        rigidbody.AddExplosionForce(10, transform.position + new Vector3(0, -1,-1), 50);
    }
}
