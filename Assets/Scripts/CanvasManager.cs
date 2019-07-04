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

    public GameObject DrawTxt;
    public GameObject GreenTxt;
    public GameObject PurpleTxt; 

    public void Start()
    {
        menu.SetActive(true);
        game.SetActive(false);
        block.SetActive(false);
        DrawTxt.SetActive(false);
        GreenTxt.SetActive(false);
        PurpleTxt.SetActive(false);
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

    public void GreenWin()
    {
        GreenTxt.SetActive(true);
    }

    public void PurpleWin()
    {
        PurpleTxt.SetActive(true);
    }

    public void Draw()
    {
        DrawTxt.SetActive(true);
    }


}
