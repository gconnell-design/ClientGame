﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    public GameObject Game;

    public GameObject P1U1HDisplay;
    public GameObject P1U2HDisplay;
    public GameObject P1U3HDisplay;
    public GameObject P1U4HDisplay;

    public GameObject P2U1HDisplay;
    public GameObject P2U2HDisplay;
    public GameObject P2U3HDisplay;
    public GameObject P2U4HDisplay;

    public Sprite P1H_1;
    public Sprite P1H_2;
    public Sprite P2H_1;
    public Sprite P2H_2;
    public Sprite PH_0;

    public int P1U1Health;
    public int P1U2Health;
    public int P1U3Health;
    public int P1U4Health;

    public int P2U1Health;
    public int P2U2Health;
    public int P2U3Health;
    public int P2U4Health;

    // Use this for initialization
    void Start () {
        P1U1Health = Game.GetComponent<GameManager>().P1U1Health;
        P1U2Health = Game.GetComponent<GameManager>().P1U2Health;
        P1U3Health = Game.GetComponent<GameManager>().P1U3Health;
        P1U4Health = Game.GetComponent<GameManager>().P1U4Health;

        P2U1Health = Game.GetComponent<GameManager>().P2U1Health;
        P2U2Health = Game.GetComponent<GameManager>().P2U2Health;
        P2U3Health = Game.GetComponent<GameManager>().P2U3Health;
        P2U4Health = Game.GetComponent<GameManager>().P2U4Health;
    }

    // Update is called once per frame
    public void HealthUpdate()
    {
        P1U1Update();
        P1U2Update();
        P1U3Update();
        P1U4Update();

        P2U1Update();
        P2U2Update();
        P2U3Update();
        P2U4Update();
    }    
    void P1U1Update()
    {
        if (P1U1Health >= 2)
        {
            Debug.Log("hi");
            P1U1Health = 2;
            P1U1HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_2;
        }
        else if (P1U1Health == 1)
        {
            P1U1HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_1;
        }
        else if (P1U1Health <= 0)
        {
            P1U1Health = 0;
            P1U1HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }

    } 
    
    void P1U2Update()
    {
        if (P1U2Health >= 2)
        {
            P1U2Health = 2;
            P1U2HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_2;
        }
        else if (P1U2Health == 1)
        {
            P1U2HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_1;
        }
        else if (P1U2Health <= 0)
        {
            P1U2Health = 0;
            P1U2HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }

    void P1U3Update()
    {
        if (P1U3Health >= 2)
        {
            P1U3Health = 2;
            P1U3HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_2;
        }
        if (P1U3Health == 1)
        {
            P1U3HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_1;
        }
        if (P1U3Health <= 0)
        {
            P1U3Health = 0;
            P1U3HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }

    void P1U4Update()
    {
        if (P1U4Health >= 2)
        {
            P1U4Health = 2;
            P1U4HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_2;
        }
        if (P1U4Health == 1)
        {
            P1U4HDisplay.GetComponent<SpriteRenderer>().sprite = P1H_1;
        }
        if (P1U4Health <= 0)
        {
            P1U4Health = 0;
            P1U4HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }

    void P2U1Update()
    {
        if (P2U1Health >= 2)
        {
            P2U1Health = 2;
            P2U1HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_2;
        }
        if (P2U1Health == 1)
        {
            P2U1HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_1;
        }
        if (P2U1Health <= 0)
        {
            P2U1Health = 0;
            P2U1HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }

    void P2U2Update()
    {
        if (P2U2Health >= 2)
        {
            P2U2Health = 2;
            P2U2HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_2;
        }
        if (P2U2Health == 1)
        {
            P2U2HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_1;
        }
        if (P2U2Health <= 0)
        {
            P2U2Health = 0;
            P2U2HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }

    void P2U3Update()
    {
        if (P2U3Health >= 2)
        {
            P2U3Health = 2;
            P2U3HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_2;
        }
        if (P2U3Health == 1)
        {
            P2U3HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_1;
        }
        if (P2U3Health <= 0)
        {
            P2U3Health = 0;
            P2U3HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }

    void P2U4Update()
    {
        if (P2U4Health >= 2)
        {
            P2U4Health = 2;
            P2U4HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_2;
        }
        if (P2U4Health == 1)
        {
            P2U4HDisplay.GetComponent<SpriteRenderer>().sprite = P2H_1;
        }
        if (P2U4Health <= 0)
        {
            P2U4Health = 0;
            P2U4HDisplay.GetComponent<SpriteRenderer>().sprite = PH_0;
        }
    }
}
