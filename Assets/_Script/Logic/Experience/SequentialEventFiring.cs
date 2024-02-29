using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SequentialEventFiring : MonoBehaviour
{
    [Header("CONFIG")]
    [SerializeField] bool playOnEnable;

    [Header("EVENT SEQUENCES")]
    [SerializeField] EventWaitTime[] eventSequence;

    int currentIndex;

    // Start is called before the first frame update
    void OnEnable()
    {
        currentIndex = 0;
        if (playOnEnable) StartEventSequence();
    }

    public void StartEventSequence()
    {
        StartCoroutine(HandleEventWaitTime());
    }

    IEnumerator HandleEventWaitTime()
    {
        float waitTime = eventSequence[currentIndex].timeToWaitAfterPreviousEvent;
        float currentTime = 0;

        while(currentTime < waitTime)
        {
            currentTime += Time.deltaTime;
            yield return null;
        }

        eventSequence[currentIndex].eventsToFire?.Invoke();

        currentIndex++;

        if (currentIndex < eventSequence.Length) StartCoroutine(HandleEventWaitTime());
    }
}

[System.Serializable]
public class EventWaitTime
{
    public float timeToWaitAfterPreviousEvent;
    public UnityEvent eventsToFire;
}