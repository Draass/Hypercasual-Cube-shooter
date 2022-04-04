using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorPlay : MonoBehaviour
{

    public string levelToLoad;
    
    public void PlaySelectedLevel ()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
