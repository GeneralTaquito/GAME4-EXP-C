using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.Rendering.DebugUI;

public class Bomb : MonoBehaviour
{
    public float Dropspeed = 5f;
    public ParticleSystem PS;

    void Start()
    {
        PS.Emit(1);
    }
    void Update()
    {
        transform.Translate(Vector3.down * Dropspeed * Time.deltaTime);
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
}