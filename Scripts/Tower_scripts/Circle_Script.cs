using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Circle_Script : MonoBehaviour
{
    //������� ��������� ���� � ������� �����
    public event UnityAction<Circle_Script> BulletHit;

    public void Break()
    {
        BulletHit?.Invoke(this);

        Destroy(gameObject);
    }


}
