using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TweenMove : MonoBehaviour
{
    [SerializeField] Transform endPosition;
    [SerializeField] float animationTime;
    [SerializeField] LeanTweenType easeType;

    [SerializeField] UnityEvent OnComplete;

    public void Move()
    {
        LeanTween.move(gameObject, endPosition.position, animationTime).setEase(easeType).setOnComplete(() => OnComplete?.Invoke());
    }
}
