using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationToPortalWorld : MonoBehaviour
{
    [SerializeField] Collider targetCollider;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 contactPoint = collision.GetContact(0).point;
        Vector3 localContactPoint = transform.InverseTransformPoint(contactPoint);

        Vector3 targetWorldPoint = targetCollider.transform.TransformPoint(localContactPoint);

        collision.transform.position = targetWorldPoint;
    }
}
