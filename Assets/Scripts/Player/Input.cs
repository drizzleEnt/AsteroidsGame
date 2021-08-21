using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    public static PlayerInput Inputs;

    private void Awake()
    {
         Inputs = new PlayerInput();
        Inputs.Enable();
    }

    private void OnDisable()
    {
        Inputs.Disable();
    }
}
