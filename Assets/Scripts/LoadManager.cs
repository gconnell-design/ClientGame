using System.Collections;
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

    public void Update()
    {
        if ((SceneManager.GetActiveScene().buildIndex == 2) && (Input.GetKeyDown("joystick 1 button 1")))
        {
            SceneManager.LoadScene(0);
        }
    }
}
