﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager: MonoBehaviour {

	public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadHowToScene()
    {
        SceneManager.LoadScene(2);
    }
}
