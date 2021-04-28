using System;
using UnityEngine;

namespace Game
{
    class BonusScore : MonoBehaviour, IBonus
    {
        private Score _score;

        private void Awake()
        {
            _score = FindObjectOfType<Score>();
        }
        public void Bonus()
        {
            _score.MyScore++;
        }
    }
}
