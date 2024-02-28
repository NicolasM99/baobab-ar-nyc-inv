using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TweenExplosion : MonoBehaviour
{
    [SerializeField] float expansionTime;
    [SerializeField] float expansionScaleFactor;
    [SerializeField] LeanTweenType expansionEase;

    [SerializeField] float implosionTime;
    [SerializeField] LeanTweenType implosionEase;

    [SerializeField] UnityEvent OnExplode;

    public void Explode()
    {
        LeanTween.scale(gameObject, transform.localScale * expansionScaleFactor, expansionTime).setEase(expansionEase).setOnComplete(()
            => LeanTween.scale(gameObject, Vector3.zero, implosionTime).setEase(implosionEase).setOnComplete(()
            => OnExplode?.Invoke()));
    }
}
