using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvitationCameraMovement : MonoBehaviour
{
    [SerializeField] Transform finalSpot;
    [SerializeField] float movementTime;

    public void StartAnimation(Transform cameraParent)
    {
        transform.SetParent(cameraParent);
        StartCoroutine(HandleAnimation());
    }

    IEnumerator HandleAnimation()
    {
        float currentTime = 0;

        while(currentTime < movementTime)
        {
            currentTime += Time.deltaTime;
            gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, finalSpot.localPosition, currentTime / movementTime);
            gameObject.transform.localRotation = Quaternion.Lerp(gameObject.transform.localRotation, finalSpot.localRotation, currentTime / movementTime);
            yield return null;
        }
    }
}
