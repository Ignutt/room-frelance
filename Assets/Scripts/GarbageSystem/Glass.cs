using GameSystem;
using UnityEngine;

namespace GarbageSystem
{
    public class Glass : Garbage
    {
        [SerializeField] private float changeFactor = 0.1f;
        [SerializeField] private float minValue = 0.3f;
    
        private MeshRenderer _meshRenderer;
    
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
            Color color = _meshRenderer.material.color;

            if (color.a <= minValue)
            {
                CleanUp();
                Destroy(this);
                return;
            }
        
            color.a -= changeFactor;

            _meshRenderer.material.color = color;
        }
    }
}
