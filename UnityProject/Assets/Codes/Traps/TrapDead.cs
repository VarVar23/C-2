using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game
{
    public class TrapDead : MonoBehaviour, ITraps
    {
        private GameObject _player;

        private void Awake()
        {
            _player = FindObjectOfType<PlayerMove>().gameObject;
        }
        public void Trap()
        {
            Destroy(_player);
        }
    }
}

