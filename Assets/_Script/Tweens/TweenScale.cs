using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TweenScale : MonoBehaviour
{
    [SerializeField] Vector3 targetScale;
    [SerializeField] float animationTime;
    [SerializeField] LeanTweenType easeType;

    [SerializeField] float startDelay;

    [SerializeField] bool playsOnEnable;
    [SerializeField] bool scalesToZeroOnDisable;
    [SerializeField] bool startsScaledToZero;

    [SerializeField] UnityEvent OnComplete;

    private void Start()
    {
        if (startsScaledToZero) gameObject.transform.localScale = Vector3.zero;
    }

    void OnEnable()
    {
        if (playsOnEnable) LeanTween.scale(gameObject, targetScale, animationTime).setEase(easeType).setDelay(startDelay).setOnComplete(() => OnComplete?.Invoke());
    }

    public void TweenOpen()
    {
        LeanTween.scale(gameObject, targetScale, animationTime).setEase(easeType).setDelay(startDelay).setOnComplete(() => OnComplete?.Invoke());
    }

    public void TweenClose()
    {
        LeanTween.scale(gameObject, Vector3.zero, animationTime).setEase(easeType).setDelay(startDelay).setOnComplete(Disable);
    }

    void Disable()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        if (scalesToZeroOnDisable)
        {
            LeanTween.pause(gameObject);
            gameObject.transform.localScale = Vector3.zero;
        }
    }
}