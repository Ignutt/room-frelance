using GameSystem;
using UnityEngine;
using UnityEngine.Events;

namespace GarbageSystem
{
    public class RoomLight : Garbage
    {
        [Header("Clean up")] 
        [SerializeField] private UnityEvent onLight;

        private bool _isActive = false;
        
        public override void CleanUp()
        {
            if (_isActive) return;
            
            enabled = false;
            _isActive = true;
            GameManager.Instance.RemoveGarbage(this);

            base.CleanUp();
        }

        public override void OnClick()
        {
            onLight?.Invoke();
            CleanUp();
        }
    }
}