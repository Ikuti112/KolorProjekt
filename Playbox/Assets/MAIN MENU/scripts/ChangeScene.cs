﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void NextScene()
    {

        SceneManager.LoadScene(gameObject.tag);
        Time.timeScale = 1.0F;
    }
}

