using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenFadeIn : MonoBehaviour
{
    [SerializeField] Image imageToFade;
    [SerializeField] float fadeInTime;
    [SerializeField] bool playOnEnable;

    // Start is called before the first frame update
    void OnEnable()
    {
        if (playOnEnable) StartFadeIn();
    }

    public void StartFadeIn()
    {
        StartCoroutine(HandleFadeIn());
    }

    private IEnumerator HandleFadeIn()
    {
        float currentTime = 0;

        while(currentTime < fadeInTime)
        {
            currentTime += Time.deltaTime;
            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, currentTime / fadeInTime);
            yield return null;
        }
    }
}
