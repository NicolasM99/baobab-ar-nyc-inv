using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitBeforeEvent : MonoBehaviour
{
    [SerializeField] float timeToWait;
    [SerializeField] UnityEvent OnWaitComplete;

    [SerializeField] bool playOnEnable;

    // Start is called before the first frame update
    void OnEnable()
    {
        if (playOnEnable) StartWait();
    }

    public void StartWait()
    {
        StartCoroutine(HandleWait());
    }

    IEnumerator HandleWait()
    {
        yield return new WaitForSeconds(timeToWait);

        OnWaitComplete?.Invoke();
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
