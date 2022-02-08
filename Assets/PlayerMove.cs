using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   [SerializeField] private Animator _animator;
    private float _lastDirH;
    private float _lastDirV;
    private float AxisV;
    private float AxisH;
    public float speed = 3;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        AxisH = Input.GetAxisRaw("Horizontal");
        AxisV = Input.GetAxisRaw("Vertical");
        _animator.SetBool("is moving", false);
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            _lastDirH = AxisH;
            _lastDirV = AxisV;
            _animator.SetFloat("hor", _lastDirH);
            _animator.SetFloat("ver", _lastDirV);
            _animator.SetBool("is moving", true);
        }
        




    }

    private void FixedUpdate()
    {
        rb.MovePosition(new Vector2(transform.position.x + AxisH * Time.deltaTime * speed, transform.position.y + AxisV * Time.deltaTime * speed));

        //transform.Translate(new Vector2(0, AxisV * Time.deltaTime * speed));
        //transform.Translate(new Vector2(AxisH * Time.deltaTime * speed, 0));
    }
}
