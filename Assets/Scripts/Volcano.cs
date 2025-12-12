using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public GameObject Player;

    public float Speed;

    void Update()
    {
        Vector2 vel = RB.linearVelocity;

        vel.x = -2;

        RB.linearVelocity = vel;

        if (transform.position.y < -10)
        {
        //respawn i guess
        }

    }

    Vector3 DirectionToPlayer()
    {
        return (Player.transform.position - transform.position).normalized;
    }
}
