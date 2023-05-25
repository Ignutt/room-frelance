using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    [SerializeField] private float changeFactor = 0.1f;
    [SerializeField] private float minValue = 0.3f;
    
    private MeshRenderer _meshRenderer;
    
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        Color color = _meshRenderer.material.color;

        if (color.a <= minValue) return;
        
        color.a -= changeFactor;

        _meshRenderer.material.color = color;
    }
}
