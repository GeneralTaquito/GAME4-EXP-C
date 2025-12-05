using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenu_UI : MonoBehaviour
{
    public Button playGameButton;
    public Button quitGameButton;
    
    void Start()
    {
        playGameButton.onClick.AddListener(StartPlay);
        quitGameButton.onClick.AddListener(ExitGame);
    }
    
    void StartPlay()
    {
        sceneManager.Instance.LoadNewGame();
    }

    void ExitGame()
    {
        
    }
}
