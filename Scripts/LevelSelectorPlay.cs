using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorPlay : MonoBehaviour
{
    [SerializeField] private string levelToLoad;
    
    public void PlaySelectedLevel ()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
