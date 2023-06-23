using GarbageSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private void Start()
    {
        InputHandler.Instance.OnClick += (GameObject sender) =>
        {
            if (sender == null || sender.TryGetComponent<Garbage>(out var garabe) == false)
            {
                AudioManager.Instance.Play(AudioConfig.EmptyClean);
                return;
            }
        };
    }
}
