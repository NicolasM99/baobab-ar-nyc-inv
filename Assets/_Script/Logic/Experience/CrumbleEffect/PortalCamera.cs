using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = Camera.main.transform.rotation * Quaternion.Euler(1.5f, 1.5f, 1.5f);
    }
}
