using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.Rendering.DebugUI;

public class Canon : MonoBehaviour
{
    public float Dropspeed = 5f;
    public ParticleSystem PS;

    void Start()
    {
        PS.Emit(1);
    }

    void Update()
    {
        transform.Translate(Vector3.left * Dropspeed * Time.deltaTime);
    }

    public int CanonValue = -10;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            {
                if (GameMan.Instance != null)
                {
                    GameMan.Instance.AddScore(CanonValue);
                }

                Destroy(gameObject);
            }
        }

    }

}