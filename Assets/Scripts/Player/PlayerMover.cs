using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private PlayerInput _playerInput;
    private Rigidbody2D  _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _playerInput = new PlayerInput();
    }
    
    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        
      float direction = _playerInput.Player.Move.ReadValue<float>();
        Move(direction);
        
    }

    private void Move(float direction)
    {
        float scaledSpeed = _speed * Time.deltaTime;
       
        _rigidbody.AddForce(transform.up * direction * scaledSpeed, ForceMode2D.Impulse);
    }

}
