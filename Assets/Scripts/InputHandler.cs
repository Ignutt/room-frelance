using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : Singletone<InputHandler>
{
    public event Action<GameObject> OnClick;
    
    public override void OnAwake()
    {
        Instance = this;
    }

    public void Click(GameObject sender)
    {
        OnClick?.Invoke(sender);
    }
}
