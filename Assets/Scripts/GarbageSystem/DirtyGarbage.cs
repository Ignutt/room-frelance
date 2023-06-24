using GameSystem;
using UnityEngine;

namespace GarbageSystem
{
    public class DirtyGarbage : Garbage
    {
        [SerializeField] private MeshRenderer meshRenderer;
        [SerializeField] private Material[] material;

        private int _currentIndex = 0;

        public override void CleanUp()
        {
            GameManager.Instance.RemoveGarbage(this);
            base.CleanUp();
        }

        public override void OnClick()
        {
            Debug.Log("Enter!");
            if (_currentIndex >= material.Length) return;
            
            meshRenderer.material = material[_currentIndex++];
            
            if (_currentIndex >= material.Length)
            {
                CleanUp();
            }
        }
    }
}
