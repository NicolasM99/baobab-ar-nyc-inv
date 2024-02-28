using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCracking : MonoBehaviour
{
    [SerializeField] Material crackingMaterial;
    [SerializeField] float startingCracksValue;
    [SerializeField] float changePerTap;
    float currentCracks;

    private void Start()
    {
        crackingMaterial.SetFloat("_CracksAmount", startingCracksValue);
        currentCracks = 0;
    }

    public void IncreaseMaterialCracking()
    {
        currentCracks += changePerTap;
        crackingMaterial.SetFloat("_CracksAmount", currentCracks);
    }
}
