using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    [SerializeField] Vector3 targetPosition;

    public void Move()
    {

        transform.position = targetPosition;
    }
}
