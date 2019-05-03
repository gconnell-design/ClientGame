using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using XboxCtrlrInput;

public class GameManager : MonoBehaviour
{

    public Unit P1Slot1;
    public Unit P1Slot2;
    public Unit P1Slot3;
    public Unit P1Slot4;
    public Unit P2Slot1;
    public Unit P2Slot2;
    public Unit P2Slot3;
    public Unit P2Slot4;

    public GameObject P1UnitOne;
    public GameObject P1UnitTwo;
    public GameObject P1UnitThree;
    public GameObject P1UnitFour;

    public Text P1Slot1T;
    public Text P1Slot2T;
    public Text P1Slot3T;
    public Text P1Slot4T;

    public GameObject P2UnitOne;
    public GameObject P2UnitTwo;
    public GameObject P2UnitThree;
    public GameObject P2UnitFour;

    public Text P2Slot1T;
    public Text P2Slot2T;
    public Text P2Slot3T;
    public Text P2Slot4T;

    public bool turnOne;

    public Text PhaseTxt;
    public GameObject Game;
    public float currentTime;

    public int P1Turn = 1;


   

    // Use this for initialization
    void Start()
    {
        
        P1Slot1 = new Unit();
        P1Slot1.Name = "Knight";
        P1Slot1.HP = 2;
        P1Slot1.Att = 1;
        P1Slot1T.text = P1Slot1.Name;

        P1Slot2 = new Unit();
        P1Slot2.Name = "Knight";
        P1Slot2.HP = 2;
        P1Slot2.Att = 1;
        P1Slot2T.text = P1Slot2.Name;

        P1Slot3 = new Unit();
        P1Slot3.Name = "Knight";
        P1Slot3.HP = 2;
        P1Slot3.Att = 1;
        P1Slot3T.text = P1Slot3.Name;

        P1Slot4 = new Unit();
        P1Slot4.Name = "Priest";
        P1Slot4.HP = 2;
        P1Slot4.Heal = 1;
        P1Slot4T.text = P1Slot4.Name;

        P2Slot1 = new Unit();
        P2Slot1.Name = "Knight";
        P2Slot1.HP = 2;
        P2Slot1.Att = 1;
        P2Slot1T.text = P2Slot1.Name;

        P2Slot2 = new Unit();
        P2Slot2.Name = "Knight";
        P2Slot2.HP = 2;
        P2Slot2.Att = 1;
        P2Slot2T.text = P2Slot2.Name;

        P2Slot3 = new Unit();
        P2Slot3.Name = "Knight";
        P2Slot3.HP = 2;
        P2Slot3.Att = 1;
        P2Slot3T.text = P2Slot3.Name;

        P2Slot4 = new Unit();
        P2Slot4.Name = "Priest";
        P2Slot4.HP = 2;
        P2Slot4.Heal = 1;
        P2Slot4T.text = P2Slot4.Name;

        P1UnitOne.SetActive(false);
        turnOne = true;

    }

    public void Update()
    {
        if (turnOne)
        {
            P1UnitOne.SetActive(true);
            P1UnitTwo.SetActive(false);
            P1Turn += 1;
            turnOne = false;
        }
        currentTime = Game.GetComponent<CountdownTimer>().currentTime;
        if (currentTime > 0f)
        {
            PhaseTxt.text = "Action Phase";
        }

        if (currentTime <= 0f)
        {
            PhaseTxt.text = "Results";
        }

        if ((P1Turn == 1) && ((Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("joystick button 2") || Input.GetKeyDown("joystick button 3"))))
        {
            turnOne = true;
        }

        if ((P1Turn == 2) && ((Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("joystick button 2") || Input.GetKeyDown("joystick button 3"))))
        {
            P1UnitTwo.SetActive(true);
            P1UnitThree.SetActive(false);
            P1Turn += 1;
        }

        if ((P1Turn == 3) && ((Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("joystick button 2") || Input.GetKeyDown("joystick button 3"))))
        {
            P1UnitThree.SetActive(true);
            P1UnitFour.SetActive(false);
            P1Turn += 1;
        }

        if ((P1Turn == 4) && ((Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("joystick button 1") || Input.GetKeyDown("joystick button 2") || Input.GetKeyDown("joystick button 3"))))
        {
            P1UnitFour.SetActive(true);
            P1Turn += 1;
        }

        Debug.Log(P1Turn);

    }
}
