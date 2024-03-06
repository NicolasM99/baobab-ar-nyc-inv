#region Assembly RuntimeAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Users\alejo\Documents\Unity projects\SPACEDANTA\baobab-ar-nyc-inv\Library\ScriptAssemblies\RuntimeAssembly.dll
#endregion

using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class CustomFractureObject : MonoBehaviour
{
    public TriggerOptions triggerOptions;
    public FractureOptions fractureOptions;
    public RefractureOptions refractureOptions;
    public CallbackOptions callbackOptions;
    [HideInInspector]
    public int currentRefractureCount;

    public CustomFractureObject() { }

    public void CauseFracture() { }
    public void ComputeFracture() { }
    [ContextMenu("Print Mesh Info")]
    public void PrintMeshInfo() { }
}