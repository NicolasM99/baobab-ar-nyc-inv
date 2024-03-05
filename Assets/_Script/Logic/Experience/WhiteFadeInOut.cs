using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class WhiteFadeInOut : MonoBehaviour
{
    [SerializeField] FadeInstance[] fadeInstances;
    [SerializeField] Image img;
    int currentIndex;

    private void OnEnable()
    {
        currentIndex = 0;
    }

    public void StartFadeEffect()
    {
        StartCoroutine(HandleFade());
    }

    private IEnumerator HandleFade()
    {
        float currentTime = 0;
        FadeInstance currentInstance = fadeInstances[currentIndex];

        while(currentTime < currentInstance.fadeInTime)
        {
            currentTime += Time.deltaTime;
            img.color = new Color(1, 1, 1, currentTime / currentInstance.fadeInTime);
            yield return null;
        }

        currentTime = 0;
        currentInstance.HoldEvent?.Invoke();

        while(currentTime < currentInstance.holdTime)
        {
            currentTime += Time.deltaTime;
            yield return null;
        }

        currentTime = 0;

        while (currentTime < currentInstance.fadeInTime)
        {
            currentTime += Time.deltaTime;
            img.color = new Color(1, 1, 1, 1 - (currentTime / currentInstance.fadeInTime));
            yield return null;
        }

        currentIndex++;
        if (currentIndex < fadeInstances.Length) StartCoroutine(HandleFade());
    }
}

[System.Serializable]
public class FadeInstance
{
    public float fadeInTime;
    public float holdTime;
    public UnityEvent HoldEvent;
    public float fadeOutTime;
}
