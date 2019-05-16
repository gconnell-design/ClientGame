using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class LineManager : MonoBehaviour
{

    public GameObject game;
    public GameManager gameManager;
    public int P1Turn;
    public int P1Turn;

    public void Start()
    {
        P1Turn = game.GetComponent<GameManager>().P1Turn;
    }

    public void Update()
    {
        
    }

