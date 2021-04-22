using System;
using UnityEngine;

namespace Game
{
    class TrapSpeed : MonoBehaviour, ITraps
    {
        private PlayerMove _player;
        private float _temp;
        private float _timeLife = 2f;

        private void Awake()
        {
            _player = FindObjectOfType<PlayerMove>();
        }
        public void Trap()
        {
            _temp = _player.Force;
            _player.Force *= 0.25f;
            Invoke("BackTrap", _timeLife);
        }

        private void BackTrap()
        {
            _player.Force = _temp;
        }
    }
}
