using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] Vector3[] movepoints;
    [SerializeField] float movementTime;
    [SerializeField] LeanTweenType easeType;
    [SerializeField] UnityEvent OnComplete;

    [SerializeField] bool playOnEnable;

    private void OnEnable()
    {
        if (playOnEnable) MoveCamera();
    }

    public void MoveCamera()
    {
        LTDescr spline = LeanTween.moveSpline(gameObject, movepoints, movementTime).setEase(easeType).setOnComplete(() => OnComplete?.Invoke());
    }
}
