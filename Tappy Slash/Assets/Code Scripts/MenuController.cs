using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Levels To Load")]
    public string _newGameLevel;
    private string levelToLoad;
     

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);
    }

    public void LoadGameDialogYes()
    {
        if (PlayerPrefs.HasKey("NewLevel"))
        {
            levelToLoad = PlayerPrefs.GetString("NewLevel");
            SceneManager.LoadScene(levelToLoad);
        }
    }
    /*
    public void ExitButton()
    {
        Application.Quit();
    }
    */
}
