using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay_UI : MonoBehaviour
{
    public Button returnToMenuButton;

    void Start()
    {
        returnToMenuButton.onClick.AddListener(ReturnToMenu);
    }

    void ReturnToMenu()
    {
        sceneManager.Instance.LoadMainMenu();
    }
}
