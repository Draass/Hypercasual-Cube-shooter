using UnityEngine;

public class EducationUI : MonoBehaviour
{

    public GameObject educationUI;
    private float freezeGameTimer = 1f;

    private void Update ()
    {
        //stop time when game starts
        freezeGameTimer -= Time.timeScale;
        if (freezeGameTimer <= 0)
        {
            FreezeTime();
        }
    }

    private void FreezeTime()
    {
        Time.timeScale = 0;
    }

    public void CloseEducationMenu ()
    {
        Time.timeScale = 1;
        educationUI.SetActive(false);
        this.enabled = false;
    }
}
