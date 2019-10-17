using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CanvasManager : MonoBehaviour
{
    public GameObject DrawTxt;
    public GameObject GreenTxt;
    public GameObject PurpleTxt;
    public GameObject ReturnBtn;

    private void Start()
    {
        DrawTxt.SetActive(false);
        GreenTxt.SetActive(false);
        PurpleTxt.SetActive(false);
        ReturnBtn.SetActive(false);
    }

    public void GreenWin()
    {
        GreenTxt.SetActive(true);
        ReturnBtn.SetActive(true);
    }

    public void PurpleWin()
    {
        PurpleTxt.SetActive(true);
        ReturnBtn.SetActive(true);
    }

    public void Draw()
    {
        DrawTxt.SetActive(true);
        ReturnBtn.SetActive(true);
    }

}
