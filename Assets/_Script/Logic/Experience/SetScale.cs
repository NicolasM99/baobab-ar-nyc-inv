using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    [SerializeField] Vector3 targetScale;


    public void Scale()
    {
        transform.localScale = targetScale;
    }
}
