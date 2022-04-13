using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [Header("Necessary links")]
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject optionsMenuUI;

    [Header("Next scene name")]
    public string sceneToLoad = "Level2";

    [HideInInspector]
    public bool isPaused = false;
    public bool isSetPauseMenu = false;
    public bool isSetOptionsMenu = false;

    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1;   
    }
    void Update()
    {
        SetPauseMenu();
    }

    public void QuitPauseMenu ()
    {
        if (isPaused == true)
        {
            if (Input.GetKeyDown("p") || Input.GetKeyDown("space"))
            {
                isPaused = false;
                Time.timeScale = 1;
                pauseMenuUI.SetActive(false);
            }
        }
    }

    public void SetPauseMenu ()
    {
        if (isPaused == false)
        {
            if ((Input.GetKeyDown("p") || Input.GetKeyDown("space")) && isSetOptionsMenu == false)
            {
                isPaused = true;
                Time.timeScale = 0;
                pauseMenuUI.SetActive(true);
            }
        }
        else if (isPaused == true && isSetOptionsMenu == false)
        {
            QuitPauseMenu();
        }
    }

    public void PauseMenuButton ()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
    }

    public void Continue ()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    public void OptionsMenu ()
    {
        optionsMenuUI.SetActive(true);
        isSetOptionsMenu = true;
        pauseMenuUI.SetActive(false);
        Debug.Log("Open options");
    }

    public void BackToPauseMenu ()
    {
        isSetOptionsMenu = false;
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void QuitToDesktop ()
    {
        Debug.Log("Go to desktop");
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        Debug.Log("Go to main menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel ()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
