using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject LevelCompleteUI;

    [SerializeField] private int nextLevelIndex = 2;

    public void LevelComplete()
    {
        Time.timeScale = 0;
        LevelCompleteUI.SetActive(true);
        Debug.Log("Level complete!");

        //set actual level
        PlayerPrefs.SetInt("levelReached", nextLevelIndex);
    }
}
