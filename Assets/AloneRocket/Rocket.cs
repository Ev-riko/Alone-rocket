using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    private Vector2 _direction;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        _rigidbody2D.velocity += _direction * _speed;
        //transform.rotation = Quaternion.LookRotation(_rigidbody2D.velocity);
    }

    public void SetDirectoin(Vector2 direction)
    {
        _direction = direction;
    }
}
