using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static sceneManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    //List of Scenes in the build Index, make sure they are in ORDER.
    public enum Scene
    {
        Main_Menu,
        Game_Scene
    }



    //List of Scene Functions.

    //Used to refrence any specific scene on the build index.
    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }


    //Used for the Start Game Button.
    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Game_Scene.ToString());
    }

    //Loads next Scene in build index.
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    //Loads the Main Menu Scene.
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Main_Menu.ToString());
    }

    //Restarts the current Scene.
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
