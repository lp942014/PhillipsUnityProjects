using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class highlight : MonoBehaviour, IFocusable
{
    public Color highlightColor;
    public Color instanceColor;
    
    private Renderer rendererInstance;
    private Material materialInstance;

    private void Awake()
    {
        rendererInstance = GetComponent<Renderer>();
        materialInstance = rendererInstance.material;
        instanceColor = materialInstance.color;
    }

    private void OnDestroy()
    {
        Destroy(materialInstance);
    }

    public void OnFocusEnter()
    {
        materialInstance.color = highlightColor;
    }

    public void OnFocusExit()
    {
        materialInstance.color = instanceColor;
    }
}
