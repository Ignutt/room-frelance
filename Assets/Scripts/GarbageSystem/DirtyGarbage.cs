using GameSystem;
using UnityEngine;

namespace GarbageSystem
{
    public class DirtyGarbage : Garbage
    {
        [SerializeField] private Material[] material;

        private MeshRenderer _meshRenderer;
        private int _currentIndex = 0;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public override void CleanUp()
        {
            GameManager.Instance.RemoveGarbage(this);
        }

        public override void OnClick()
        {
            if (_currentIndex >= material.Length) return;
            
            _meshRenderer.material = material[_currentIndex++];
            
            if (_currentIndex >= material.Length)
            {
                CleanUp();
            }
        }
    }
}
