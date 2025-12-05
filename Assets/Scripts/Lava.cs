using UnityEngine;


public class Lava : MonoBehaviour
{
    public Collider2D Coll;
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Vector2 vel = RB.linearVelocity;
        RB.linearVelocity = vel;

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

}