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

    [SerializeField] private AudioClip Flap;
    [SerializeField] private AudioClip Over;
    [SerializeField] private AudioClip ScoreUp;
    [SerializeField] private AudioSource src;
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
            src.clip = Flap;
            src.Play();
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        src.clip = ScoreUp;
        src.Play();
        Score.Instance.UpdateScore();
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision");
        src.clip = Over;
        src.Play();
        GameManager.instance.GameOver();
    }
    

    
}
