using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;

    public float Jump;

    public List<GameObject> Grounds;

    public float DesiredVel;

    void Update()
    {
        Vector2 vel = RB.linearVelocity;

        if (Input.GetKeyDown(KeyCode.Space) && CanJump())
        {
            vel.y = Jump;
        }

        RB.linearVelocity = vel;

        if (transform.position.y < -20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public bool CanJump()
    {
        return Grounds.Count > 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Grounds.Add(other.gameObject);

        //Separate code for when getting dog treats and hitting obstacles
    }
}