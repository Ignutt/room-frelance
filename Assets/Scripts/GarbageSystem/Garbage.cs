using System;
using GameSystem;
using UnityEngine;

namespace GarbageSystem
{
    public abstract class Garbage : MonoBehaviour
    {
        private void Start()
        {
            GameManager.Instance.AddGarbage(this);
        }

        private void OnMouseDown()
        {
            OnClick();
        }

        public abstract void CleanUp();
        public abstract void OnClick();
    }
    
}