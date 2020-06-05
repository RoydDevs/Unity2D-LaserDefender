﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}