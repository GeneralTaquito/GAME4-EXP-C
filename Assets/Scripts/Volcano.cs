using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public GameObject Lava;
    public GameObject Player;
    public float SpewInt;

    public float Speed;

    void Start()
    {
        InvokeRepeating("StartSpewin", .5f, SpewInt);
    }

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

    void StartSpewin()
    {
        Debug.Log("time passed: " + Time.time);
        GameObject temp = Instantiate(Lava, transform.position, Quaternion.identity);
        Rigidbody2D rb = temp.GetComponent<Rigidbody2D>();
        rb.linearVelocity = DirectionToPlayer()*Speed;
    }

    Vector3 DirectionToPlayer()
    {
        return (Player.transform.position - transform.position).normalized;
    }
}
