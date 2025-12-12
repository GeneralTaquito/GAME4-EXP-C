using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
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
            SceneManager.LoadScene("End Scene");
            Remainingtime = 0;
        }

        int seconds = Mathf.FloorToInt(Remainingtime % 60);
        TimeNumber.text = string.Format("{0:00}", seconds);
    }
}