using GameSystem;
using UnityEngine;
using UnityEngine.Events;

namespace GarbageSystem
{
    public class RoomLight : Garbage
    {
        [Header("Clean up")] 
        [SerializeField] private UnityEvent onLight;
        
        public override void CleanUp()
        {
            GameManager.Instance.RemoveGarbage(this);
        }

        public override void OnClick()
        {
            onLight?.Invoke();
            CleanUp();
        }
    }
}