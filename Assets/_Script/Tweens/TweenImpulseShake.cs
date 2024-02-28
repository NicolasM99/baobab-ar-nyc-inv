using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenImpulseShake : MonoBehaviour
{
    [SerializeField] Vector3 minAmountToShake;
    [SerializeField] Vector3 maxAmountToShake;
    [SerializeField] float shakeTime;
    [SerializeField] int loopCount;

    Vector3 startingScale;

    private void Start()
    {
        startingScale = gameObject.transform.localScale;
    }

    public void ShakeSelf()
    {
        float amountToShakeX = Random.Range(minAmountToShake.x, maxAmountToShake.x);
        float amountToShakeY = Random.Range(minAmountToShake.y, maxAmountToShake.y);
        float amountToShakeZ = Random.Range(minAmountToShake.z, maxAmountToShake.z);

        Vector3 targetScale = new Vector3(gameObject.transform.localScale.x + amountToShakeX,
            transform.localScale.y + amountToShakeY,
            transform.localScale.z + amountToShakeZ);

        LeanTween.scale(gameObject, targetScale, shakeTime).setOnComplete(() => LeanTween.scale(gameObject, startingScale, shakeTime));   
    }
}
