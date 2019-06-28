using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{

    public float currentTime;

    public int turnNumber;
    public int P1Turn;
    public int P2Turn;

    public bool canInvoke;

    public Text PhaseTxt;

    public GameObject Game;
    public GameObject healthManager;
    public GameObject block;
    public GameObject timerTxt;
    public GameObject timerTxt0;

    // Use this for initialization
    void Start()
    {
        turnNumber = 1;
        canInvoke = true;
        timerTxt0.SetActive(false);
        timerTxt.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Game.GetComponent<CountdownTimer>().currentTime;
        P1Turn = Game.GetComponent<GameManager>().P1Turn;
        P2Turn = Game.GetComponent<GameManager>().P2Turn;

        if (currentTime > 0f)
        {
            PhaseTxt.text = "Turn " + turnNumber;
        }

        if ((((P1Turn == 5) && (P2Turn == 5)) || (currentTime <= 0)) && (canInvoke))
        {
            ResultPhase();
            timerTxt.SetActive(false);
            timerTxt0.SetActive(true);
            PhaseTxt.text = "Turn " + turnNumber + " Results";
        }
    }

    void ResultPhase()
    {
        block.SetActive(false);
        canInvoke = false;
        healthManager.GetComponent<HealthManager>().HealthUpdate();
        Invoke("ResetPhase", 5);
    }

    void ResetPhase()
    {
        Game.GetComponent<GameManager>().P1Turn = 1;
        Game.GetComponent<GameManager>().P2Turn = 1;
        timerTxt.SetActive(true);
        timerTxt0.SetActive(false);
        turnNumber += 1;
        canInvoke = true;
        Game.GetComponent<CountdownTimer>().currentTime = 30;
        block.SetActive(true);
        Game.GetComponent<GameManager>().NewTurnReset();
    }
}
