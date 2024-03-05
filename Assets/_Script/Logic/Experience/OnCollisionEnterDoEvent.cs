using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEnterDoEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnCollisionEvent;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        OnCollisionEvent?.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        OnCollisionEvent?.Invoke();
    }
}
