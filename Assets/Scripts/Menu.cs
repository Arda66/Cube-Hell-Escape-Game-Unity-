﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void ImpossibleLevelOpen()
    {
        SceneManager.LoadScene("EndlessSurvival");
    }
}
