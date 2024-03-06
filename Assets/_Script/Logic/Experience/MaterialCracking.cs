using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaterialCracking : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] string propertyToAffect;
    [SerializeField] float steps;
    [SerializeField] float maxLerpValue;
    [SerializeField] float startingValue;
    [SerializeField] float animationTime;
    [SerializeField] float lerpTime;

    [SerializeField] bool debugMode;

    [SerializeField] TextMeshProUGUI materialNameText;
    [SerializeField] TextMeshProUGUI materialFloatText;

    Material materialCopy;

    private void OnEnable()
    {
        materialCopy = new Material(meshRenderer.material);
        meshRenderer.material = materialCopy;
        materialCopy.SetFloat(propertyToAffect, startingValue);

        if(debugMode && materialNameText.isActiveAndEnabled) materialNameText.text = "Current material is " + materialCopy.name;
        if(debugMode && materialFloatText.isActiveAndEnabled) materialFloatText.text = "Current sphere mask value is " + materialCopy.GetFloat(propertyToAffect);
    }

    public void StartCracks()
    {
        StartCoroutine(HandleCracks());
    }

    IEnumerator HandleCracks()
    { 
        float currentTime = 0;
        float differencePerStep = startingValue / steps;
        float animationTimePerStep = animationTime / steps;
        float currentStep;
        float targetStep;

        for(int i = 0; i < steps; i++)
        {
            while (currentTime < animationTimePerStep)
            {
                currentTime += Time.deltaTime;
                yield return null;
            }

            currentTime = 0;
            currentStep = startingValue - (differencePerStep * (i)); // 1   ->   20 - (3.33 * 1) = 16.667
            targetStep = startingValue - (differencePerStep * (i + 1)); //1    ->  16.

            Debug.Log("Current step " + currentStep + " and targetStep is " + targetStep);

            while (currentTime < lerpTime)
            {
                currentTime += Time.deltaTime;
                materialCopy.SetFloat(propertyToAffect, Mathf.Lerp(currentStep, targetStep, currentTime / lerpTime));
                if (debugMode && materialFloatText.isActiveAndEnabled)  materialFloatText.text = "Current sphere mask value is " + materialCopy.GetFloat(propertyToAffect);
                yield return null;
            }
            currentTime = 0;
        }
        
    }
}
