using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BonusSpeed : MonoBehaviour, IBonus
    {
        private PlayerMove _player;
        private float _temp;
        private int _timeLife = 2;
        

        private void Awake()
        {
            _player = FindObjectOfType<PlayerMove>();
        }
        public void Bonus()
        {
            _temp = _player.Force;
            _player.Force *= 2;
            Invoke("BackBonus", _timeLife);
        }

        private void BackBonus()
        {
            _player.Force = _temp;
        }
    }
}

