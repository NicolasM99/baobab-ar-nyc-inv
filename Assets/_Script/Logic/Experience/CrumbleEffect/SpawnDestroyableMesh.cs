using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDestroyableMesh : MonoBehaviour
{
    [SerializeField] GameObject destroyableMeshPrefab;
    [SerializeField] Vector3 startRotation;

    public void SpawnMesh()
    {
       // Quaternion quaternionRotation = Quaternion.Euler(startRotation);
        GameObject instantiatedPlane = Instantiate(destroyableMeshPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
