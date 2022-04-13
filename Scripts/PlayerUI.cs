using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{ 
    public TMPro.TextMeshProUGUI enemyCounter;
    GameObject[] enemies;

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        enemyCounter.text = "Enemies left: " + enemies.Length.ToString();
    }
}
