﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManage : MonoBehaviour
{
    public void GoToNextScene(int sceneno)
    {
        SceneManager.LoadScene(sceneno);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
