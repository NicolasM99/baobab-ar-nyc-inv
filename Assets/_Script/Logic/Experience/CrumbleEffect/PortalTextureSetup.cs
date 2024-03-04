using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    [SerializeField] Camera portalCamera;
    [SerializeField] Material cameraMaterial;

    // Start is called before the first frame update
    void Start()
    {
        if(portalCamera.targetTexture != null)
        {
            portalCamera.targetTexture.Release();
        }

        portalCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMaterial.mainTexture = portalCamera.targetTexture;
    }
}
