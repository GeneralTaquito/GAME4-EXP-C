using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.Rendering.DebugUI;

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

        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        Vector2 vel = RB.linearVelocity;

        RB.linearVelocity = vel;

    }

    public int BombValue = -10;
    public void OnMouseDown()
    {
        if (GameMan.Instance != null)
        {
            GameMan.Instance.AddScore(BombValue);
        }
        Destroy(gameObject);
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
