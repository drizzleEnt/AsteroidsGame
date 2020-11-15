using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Borders : MonoBehaviour
{
    [SerializeField] protected Player Player;
    [SerializeField] protected float PositionX;
    [SerializeField] protected float PositionY;

    protected abstract void ChengePlayerPosition();
    
}
