using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyGarbage : MonoBehaviour
{
    [SerializeField] private Material[] material;

    private MeshRenderer _meshRenderer;
    private int _currentIndex = 0;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        if (_currentIndex >= material.Length) return;
        
        _meshRenderer.material = material[_currentIndex++];
    }
}
