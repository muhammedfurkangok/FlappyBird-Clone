using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehaviour : MonoBehaviour
{
    #region Self Variables

    #region Serialized Variables

    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 8f;

    #endregion

    #region Private Variables

    private Rigidbody2D _rb;

    #endregion

    #endregion

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rb.velocity = Vector2.up * _velocity;
        }
        
    }

    private void FixedUpdate()
    {
        Rotation();
    }

    private void Rotation()
    {
        transform.rotation = Quaternion.Euler(0,0,_rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.instance.GameOver();
    }
}
