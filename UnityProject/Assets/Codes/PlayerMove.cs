using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerMove : MonoBehaviour
    {
        public float Force;

        private Rigidbody _rb;
        private float _vertical;
        private float _horizontal;
        private Vector3 _move;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            _vertical = Input.GetAxis("Vertical");
            _horizontal = Input.GetAxis("Horizontal");

            _move = new Vector3(_horizontal, 0, _vertical);
            _rb.AddForce(_move * Force);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("Bonus"))
            {
               collision.gameObject.GetComponent<IBonus>().Bonus();
            }

            if(collision.gameObject.CompareTag("Trap"))
            {
                collision.gameObject.GetComponent<ITraps>().Trap();
            }
        }
    }
}
