using System;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    public float speed = 3f;
    public KeyCode interact = KeyCode.E;
    public int maxCrop = 5;

    private List<Crop> _crops = new List<Crop>();
    private Animator _animator;
    private FarmerCollider _collider;
    private float _x;
    private float _y;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _collider = GetComponentInChildren<FarmerCollider>();
    }

    private void Update()
    {
        _x = Input.GetAxisRaw("Horizontal");
        _y = Input.GetAxisRaw("Vertical");

        _animator.SetFloat("Horizontal", _x);
        _animator.SetFloat("Vertical", _y);

        if (_x == 0 && _y == 0)
        {
            _animator.speed = 0;
        }
        else
        {
            _animator.speed = 0;
        }

        if (Input.GetKeyDown(interact) && _collider.IsTouch)
        {
            Debug.Log("Touch " + _collider.Thing);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(_x, _y, 0) * speed);
    }
}