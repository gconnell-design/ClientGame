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
    public GameObject howto;
    public GameObject block;
    public Button StartBtn;
    public Button HowToBtn;

    public bool HowTo;

    public GameObject DrawTxt;
    public GameObject GreenTxt;
    public GameObject PurpleTxt; 

    public void Awake()
    {
        menu.SetActive(true);
        howto.SetActive(false);
        game.SetActive(false);
        block.SetActive(false);
        DrawTxt.SetActive(false);
        GreenTxt.SetActive(false);
        PurpleTxt.SetActive(false);

        HowTo = false;
    }

    public void Update()
    {
        StartBtn.onClick.AddListener(SwitchCanvas);
        HowToBtn.onClick.AddListener(HowToCanvas);
        
        if ((HowTo) && (Input.GetKeyDown("joystick 1 button 0")))
        {
            menu.SetActive(true);
            howto.SetActive(false);
            HowTo = false;
        }
        else
        {
            Debug.Log("HowTo: " + HowTo);
            Debug.Log("input: " + Input.GetKeyDown("joystick 1 button 0"));
        }
    }

    void SwitchCanvas()
    {
        menu.SetActive(false);
        game.SetActive(true);
        block.SetActive(true);
    }

    void HowToCanvas()
    {
        menu.SetActive(false);
        howto.SetActive(true);
        HowTo = true;
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
