using Holokit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//forc caches rendering component
[RequireComponent(typeof(Renderer))]
public class highlighter : MonoBehaviour, IFocusable
{
    public Color initialColor;
    public Color highlightColor;

    private Renderer rendererInstance;
    private Material materialInstance;

    private void Awake()
    {
        //cache and initialize color, renderer, and meterial
        rendererInstance = GetComponent<Renderer>();
        materialInstance = rendererInstance.material;
        initialColor = materialInstance.color;
    }
}