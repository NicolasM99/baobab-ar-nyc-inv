using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        GameObject.Destroy(other.gameObject);
    }
}
