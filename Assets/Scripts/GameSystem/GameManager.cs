using System;
using System.Collections.Generic;
using UnityEngine;
using GarbageSystem;

namespace GameSystem
{
    public class GameManager : Singletone<GameManager>
    {
        public event Action<int> OnGarbageChanged;

        private readonly List<Garbage> _garbagesList = new List<Garbage>();

        public int CurrentGarbagesCount { get; private set; }
        public int MaxGarbagesCount { get; private set; }
        
        public override void OnAwake()
        {
            Instance = this;
        }

        public void AddGarbage(Garbage garbage)
        {
            _garbagesList.Add(garbage);
            
            if (_garbagesList.Count > MaxGarbagesCount)
            {
                MaxGarbagesCount = _garbagesList.Count;
            }
            
            OnGarbageChanged?.Invoke(_garbagesList.Count);
        }

        public void RemoveGarbage(Garbage garbage)
        {
            _garbagesList.Remove(garbage);

            CurrentGarbagesCount++;
            OnGarbageChanged?.Invoke(_garbagesList.Count);
        }
    }
}
