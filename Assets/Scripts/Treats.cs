using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.Rendering.DebugUI;

public class Treats : MonoBehaviour
{
    public float Popspeed = 5f;
    public ParticleSystem PS;

    void Start()
    {
        PS.Emit(1);
    }
    void Update()
    {
        transform.Translate(Vector3.left * Popspeed * Time.deltaTime);
    }

    public int TreatValue = 10;
    public void OnMouseDown()
    {
        if (GameMan.Instance != null)
        {
            GameMan.Instance.AddScore(TreatValue);
        }
        Destroy(gameObject);
    }
}