using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientLightingFade : MonoBehaviour
{
    [SerializeField] float fadeInTime;
    [SerializeField] float fadeOutTime;
    [SerializeField] float holdTime;

    float minIntensity = 0.85f;
    float maxIntensity = 8f;

    public void StartFadeEffect()
    {

        StartCoroutine(HandleFade());
    }

    private IEnumerator HandleFade()
    {
        float currentTime = 0;

        while (currentTime < fadeInTime)
        {
            currentTime += Time.deltaTime;
            RenderSettings.ambientIntensity = Mathf.Lerp(minIntensity, maxIntensity, currentTime / fadeInTime);
            yield return null;
        }

        currentTime = 0;

        while (currentTime < holdTime)
        {
            currentTime += Time.deltaTime;
            yield return null;
        }

        currentTime = 0;

        while (currentTime < fadeOutTime)
        {
            currentTime += Time.deltaTime;
            RenderSettings.ambientIntensity = Mathf.Lerp(maxIntensity, minIntensity, currentTime / fadeInTime);
            yield return null;
        }
    }
}
