using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{

    //SCORE MAN START
    public static GameMan Instance;
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
        InvokeRepeating("SpawnBomb", 0f, 4f);

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

    //SCORE MAN END

    //TIME MAN START
        public TextMeshProUGUI TimeNumber;
        public float Remainingtime;

        void Update()
        {
            if (Remainingtime > 0)
            {
                Remainingtime -= Time.deltaTime;
            }
            else if (Remainingtime < 0)
            {
                SceneManager.LoadScene("End_Scene");
                Remainingtime = 0;
            }

            int seconds = Mathf.FloorToInt(Remainingtime % 60);
            TimeNumber.text = string.Format("{0:00}", seconds);
        }
    //TIME MAN END

    //SPAWN MAN START
    public GameObject Bomb;
    public Vector3 MinimumArea;
    public Vector3 MaximumArea;
    public int Bombcount = 0;
    public int MaxBombcount = 15;

    //Chunk of code for spawn area and limiting spawns
    void SpawnBomb()
    {
        if (Bombcount < MaxBombcount)
        {
            float randomX = Random.Range(MinimumArea.x, MaximumArea.x);

            Vector3 randomSpawnPosition = new Vector3(randomX, 6, 0);

            GameObject Newobject = Instantiate(Bomb, randomSpawnPosition, Quaternion.identity);
            Destroy(Newobject, 4f);

            Bombcount++;
        }
        else
        {
            CancelInvoke("SpawnBomb");
        }
    }
    //BOMB MAN START

}