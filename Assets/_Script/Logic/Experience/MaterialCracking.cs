using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCracking : MonoBehaviour
{
    [SerializeField] Material crackingMaterial;
    [SerializeField] string propertyToAffect;
    [SerializeField] float startingCracksValue;
    [SerializeField] float animationTime;

    private void Start()
    {
        crackingMaterial.SetFloat(propertyToAffect, startingCracksValue);
    }

    public void StartCracks()
    {
        StartCoroutine(HandleCracks());
    }

    IEnumerator HandleCracks()
    {
        float currentTime = 0;

        while(currentTime < animationTime)
        {
            currentTime += Time.deltaTime;
            crackingMaterial.SetFloat(propertyToAffect, Mathf.Lerp(0, 0.7f, currentTime/animationTime));
            yield return null;
        }
    }
}
