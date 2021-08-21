using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D  _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
      float direction = Input.Inputs.Player.Move.ReadValue<float>();
        Move(direction);
    }

    private void Move(float direction)
    {
        _rigidbody.AddForce(transform.up * direction * _speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        //_rigidbody.velocity = (transform.up * direction * _speed);
    }

}
