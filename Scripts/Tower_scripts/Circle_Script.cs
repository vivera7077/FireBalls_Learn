using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Circle_Script : MonoBehaviour
{
    //Событие попадания пули в сегмент башни
    public event UnityAction<Circle_Script> BulletHit;

    public void Break()
    {
        BulletHit?.Invoke(this);

        Destroy(gameObject);
    }


}
