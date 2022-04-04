using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //public string levelToLoad = "Level1";

    public GameObject mainMenuUI;
    public GameObject selectLevelUI;
    public GameObject optionsMenuUI;

    public int levelReached;

    void Update()
    {
        Debug.Log(levelReached);    
    }

    public void ResetLevelsReached ()
    {
        PlayerPrefs.SetInt("levelReached", 1);
    }

    void Start()
    {
        levelReached = PlayerPrefs.GetInt("levelReached");  
    }
    public void Play ()
    {
        SceneManager.LoadScene(levelReached);
    }

    public void SelectLevel()
    {
        selectLevelUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void BackToMainMenu ()
    {
        selectLevelUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void QuitToDesktop ()
    {
        Application.Quit();
    }

    public void Options ()
    {
        optionsMenuUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
    
    public void BackFromOptionsMenu ()
    {
        optionsMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    //функция для итоговой сцены, потом перенести
    public void GoToMainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
