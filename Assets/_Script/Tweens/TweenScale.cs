using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenScale : MonoBehaviour
{
    [SerializeField] Vector3 targetScale;
    [SerializeField] float animationTime;
    [SerializeField] LeanTweenType easeType;

    [SerializeField] float startDelay;

    [SerializeField] bool playsOnEnable;
    [SerializeField] bool scalesToZeroOnDisable;
    [SerializeField] bool startsScaledToZero;

    private void Start()
    {
        if (startsScaledToZero) gameObject.transform.localScale = Vector3.zero;
    }

    void OnEnable()
    {
        if (playsOnEnable) LeanTween.scale(gameObject, targetScale, animationTime).setEase(easeType).setDelay(startDelay);
    }

    public void TweenOpen()
    {
        LeanTween.scale(gameObject, targetScale, animationTime).setEase(easeType).setDelay(startDelay);
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