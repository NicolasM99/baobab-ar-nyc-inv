using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenImpulseShake : MonoBehaviour
{
    [SerializeField] Vector3 minAmountToShake;
    [SerializeField] Vector3 maxAmountToShake;
    [SerializeField] float shakeTime;
    [SerializeField] int loopCount;

    Vector3 defaultPosition;

    private void Start()
    {
        defaultPosition = gameObject.transform.position;
    }

    public void ShakeSelf()
    {
        float amountToShakeX = Random.Range(minAmountToShake.x, maxAmountToShake.x);
        float amountToShakeY = Random.Range(minAmountToShake.y, maxAmountToShake.y);
        float amountToShakeZ = Random.Range(minAmountToShake.z, maxAmountToShake.z);

        LeanTween.moveY(gameObject, gameObject.transform.position.y - amountToShakeY, shakeTime).setLoopCount(loopCount);
        LeanTween.moveZ(gameObject, gameObject.transform.position.z - amountToShakeZ, shakeTime).setLoopCount(loopCount);
        LeanTween.moveX(gameObject, gameObject.transform.position.x - amountToShakeX, shakeTime).setLoopCount(loopCount).setOnComplete(() => LeanTween.move(gameObject, defaultPosition, shakeTime));
    }
}
