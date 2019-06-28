using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CanvasManager : MonoBehaviour
{
    public StandaloneInputModule eventSystem;
    public GameObject menu;
    public GameObject game;
    public GameObject block;
    public Button StartBtn;

    public void Start()
    {
        menu.SetActive(true);
        game.SetActive(false);
        block.SetActive(false);
    }

    public void Update()
    {
        StartBtn.onClick.AddListener(SwitchCanvas);
    }

    void SwitchCanvas()
    {
        menu.SetActive(false);
        game.SetActive(true);
        block.SetActive(true);
    }


}
