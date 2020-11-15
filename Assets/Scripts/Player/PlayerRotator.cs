using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Vector2 _cursorPosition;
    private Vector2 _direction;
    private float _cameraDistance = -10;

    private void Awake()
    {
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
        GetCursorPosition();
    }

    private void CursorRotation(Vector2 direction)
    {
        float dY = transform.position.y - direction.y;
        float dX = transform.position.x - direction.x;
        float rot = (Mathf.Atan2(dY, dX) * (180 / Mathf.PI));
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }
    private void GetCursorPosition()
    {
        _cursorPosition = _playerInput.Player.Cursor.ReadValue<Vector2>();
        Vector2 cursorPositionInWorld = new Vector3(_cursorPosition.x, _cursorPosition.y, _cameraDistance);
        _direction = Camera.main.ScreenToWorldPoint(cursorPositionInWorld);
        CursorRotation(_direction);
    }
}
