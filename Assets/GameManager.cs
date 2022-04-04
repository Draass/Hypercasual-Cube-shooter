using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerStats playerStats;

    public GameObject LevelCompleteUI;
    public GameObject gameOverUI;

    public string nextLevel = "level2";
    public int nextLevelIndex = 2;

    public void LevelComplete()
    {
        Time.timeScale = 0;
        LevelCompleteUI.SetActive(true);
        Debug.Log("Level complete!");

        //set actual level
        PlayerPrefs.SetInt("levelReached", nextLevelIndex);
    }

    public void GameOver ()
    {
        if(playerStats.isDead == true)
        {
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
        }
    }
}
