using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStuff : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public GameObject Spit;
    public GameObject Player;
    public float SpitInt;

    public float Speed;

    void Start()
    {
        InvokeRepeating("StartSpittin", .5f, SpitInt);
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

    void StartSpittin()
    {
        Debug.Log("time passed: " + Time.time);
        GameObject temp = Instantiate(Spit, transform.position, Quaternion.identity);
        Rigidbody2D rb = temp.GetComponent<Rigidbody2D>();
        rb.linearVelocity = DirectionToPlayer()*Speed;
    }

    Vector3 DirectionToPlayer()
    {
        return (Player.transform.position - transform.position).normalized;
    }
}
