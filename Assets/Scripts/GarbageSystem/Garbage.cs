using System;
using GameSystem;
using UnityEngine;

namespace GarbageSystem
{
    public abstract class Garbage : MonoBehaviour
    {
        public bool IsCleanedUp { get; protected set; }

        private void Start()
        {
            GameManager.Instance.AddGarbage(this);
        }

        private void OnMouseDown()
        {
            OnClick();
            AudioManager.Instance.Play(AudioConfig.OnCleaning);
        }

        public virtual void CleanUp() 
        {
            IsCleanedUp = true;
            AudioManager.Instance.Play(AudioConfig.OnDone);
        }

        public abstract void OnClick();
    }
    
}