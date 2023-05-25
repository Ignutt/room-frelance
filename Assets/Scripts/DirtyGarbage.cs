using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyGarbage : MonoBehaviour
{
    [SerializeField] private Material material;

    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        _meshRenderer.material = material;
    }
}
