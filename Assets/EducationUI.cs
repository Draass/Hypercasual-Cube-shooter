using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EducationUI : MonoBehaviour
{

    public GameObject educationUI;
    public float freezeGame = 1f;

    public void Update ()
    {
        freezeGame -= Time.timeScale;
        if (freezeGame <= 0)
        {
            FreezeTime();
        }
    }

    public void FreezeTime()
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
