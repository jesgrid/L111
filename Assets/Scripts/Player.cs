using Assets.Scripts;
using System;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;
    public WinLose WinLose;

    

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }
    public void Win()
    {
        WinLose.OnPlayerWin();
        Rigidbody.velocity = Vector3.zero;
    }
    public void Die()
    {
        WinLose.OnPlayerDead();
        Rigidbody.velocity = Vector3.zero;
    }
}
