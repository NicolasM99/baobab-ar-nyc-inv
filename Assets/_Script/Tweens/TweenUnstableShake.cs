using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenUnstableShake : MonoBehaviour
{
    [SerializeField] Vector3 minAmountToShake;
    [SerializeField] Vector3 maxAmountToShake;
    [SerializeField] float shakeCycleTime;

    LTDescr currentTween;

    public void StartShake()
    {
        
        //currentTween = LeanTween.move(gameObject, )
    }

    public void EndShake()
    {

    }
}
