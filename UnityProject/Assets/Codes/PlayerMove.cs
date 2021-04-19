using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float Force;

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

}
