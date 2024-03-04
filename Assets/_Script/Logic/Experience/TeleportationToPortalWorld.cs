using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationToPortalWorld : MonoBehaviour
{
    [SerializeField] Collider targetCollider;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint point = collision.GetContact(0);
        collision.gameObject.transform.position = targetCollider.ClosestPoint(point.point);
    }
}
