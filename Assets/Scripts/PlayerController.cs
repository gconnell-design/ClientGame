using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    public void GotoGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void GotoHowToScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
