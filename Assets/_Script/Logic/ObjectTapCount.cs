using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class ObjectTapCount : MonoBehaviour
{
    [Header("CONFIG")]
    [Tooltip("Determina la cantidad de taps necesarios para activar la acción asignada")]
    [SerializeField] float maxTaps;
    [SerializeField] UnityEvent OnTap;
    [SerializeField] UnityEvent OnMaxTapsReached;

    float currentTaps;

    private void Start()
    {
        currentTaps = 0;
    }

    public void OnMouseDown()
    {
        currentTaps++;

        if (currentTaps < maxTaps) OnTap?.Invoke();
        else OnMaxTapsReached?.Invoke();
    }
}
