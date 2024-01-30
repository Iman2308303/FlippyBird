using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float UpwardForce = 200f;
    

        private Rigidbody2D _rigidbody;
    private Collider2D _collider;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (_rigidbody == null)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * UpwardForce);
            Debug.Log(message: "We should flap upwards");
        }
    }

}
