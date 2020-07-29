using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneLoader : MonoBehaviour
{
    public void OnResumeBtnClick()
    {
        FindObjectOfType<GameMaster>().ResumeGame();
    }

    public void OnMainMenuBtnClick()
    {
        SceneManager.LoadScene(0);
    }

    public void OnQuitBtnClick()
    {
        Application.Quit();
    }
}
