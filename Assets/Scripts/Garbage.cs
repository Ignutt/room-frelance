using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
