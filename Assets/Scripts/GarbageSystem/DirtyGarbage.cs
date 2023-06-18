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
        }

        public override void OnClick()
        {
            if (_currentIndex >= material.Length) return;
            
            meshRenderer.material = material[_currentIndex++];
            
            if (_currentIndex >= material.Length)
            {
                CleanUp();
            }
        }
    }
}
