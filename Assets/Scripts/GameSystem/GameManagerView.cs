using System;
using GarbageSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameSystem
{
    public class GameManagerView : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private TextMeshProUGUI garbagesCountText;
        [SerializeField] private Image progressBar;

        private void Start()
        {
            GameManager.Instance.OnGarbageChanged += count =>
            {
                UpdateUI();
            };
            
            UpdateUI();
        }
        
        private void UpdateUI()
        {
            progressBar.fillAmount = (float) GameManager.Instance.CurrentGarbagesCount / GameManager.Instance.MaxGarbagesCount;
            garbagesCountText.text = $"{GameManager.Instance.CurrentGarbagesCount}/{GameManager.Instance.MaxGarbagesCount}";
        }
    }
}
