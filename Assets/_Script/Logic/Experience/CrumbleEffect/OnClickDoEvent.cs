using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickDoEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnClick;

    private void OnMouseDown()
    {
        OnClick?.Invoke();
    }
}
