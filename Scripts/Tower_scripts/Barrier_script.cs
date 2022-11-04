using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Barrier_script : MonoBehaviour
{
    [SerializeField] private float _animation;

    private void Start()
    {
        transform.DORotate(new Vector3(0,360,0),_animation, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
    }

}
