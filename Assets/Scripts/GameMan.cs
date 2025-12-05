using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshProUGUI ScoreNumber;
    public static int Scoretotal = 00;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        UpdateScore();
    }
    void UpdateScore()
    {
        if (ScoreNumber != null)
        {
            ScoreNumber.text = Scoretotal.ToString();
        }
    }
    public void AddScore(int amount)
    {
        Scoretotal += amount;
        UpdateScore();
    }

    
}