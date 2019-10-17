using UnityEngine;
using UnityEngine.UI;

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

    public GameObject GreenOppo;
    public GameObject GreenAlly;
    public GameObject PurpleOppo;
    public GameObject PurpleAlly;

    public GameObject healthManager;
    public GameObject block;
    public Canvas canvas;

    public GameObject p1LineMaker;
    public GameObject p2LineMaker;
    public GameObject p1DblLineMaker;
    public GameObject p2DblLineMaker;

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

    public GameObject p1u1st;
    public GameObject p1u1tr;
    public GameObject p1u2st;
    public GameObject p1u2tr;
    public GameObject p1u3st;
    public GameObject p1u3tr;
    public GameObject p1u4st;
    public GameObject p1u4tr;

    public GameObject p2u1st;
    public GameObject p2u1tr;
    public GameObject p2u2st;
    public GameObject p2u2tr;
    public GameObject p2u3st;
    public GameObject p2u3tr;
    public GameObject p2u4st;
    public GameObject p2u4tr;

    public GameObject p1_4t1;
    public GameObject p1_4t2;
    public GameObject p1_4t3;
    public GameObject p1_4t4;

    public GameObject p2_4t1;
    public GameObject p2_4t2;
    public GameObject p2_4t3;
    public GameObject p2_4t4;

    public Text P2Slot1T;
    public Text P2Slot2T;
    public Text P2Slot3T;
    public Text P2Slot4T;

    public bool turnOne;
    public bool turnTwo;
    public bool turnThree;
    public bool turnFour;
    public bool turnReset;

    public bool P2turnOne;
    public bool P2turnTwo;
    public bool P2turnThree;
    public bool P2turnFour;
    public bool P2turnReset;

    public bool P1U1Dead;
    public bool P1U2Dead;
    public bool P1U3Dead;
    public bool P1U4Dead;

    public bool P2U1Dead;
    public bool P2U2Dead;
    public bool P2U3Dead;
    public bool P2U4Dead;

    public Text PhaseTxt;
    public GameObject Game;
    public float currentTime;

    public int P1Turn = 0;
    public int P2Turn = 1;

    public int P1U1Health;
    public int P1U2Health;
    public int P1U3Health;
    public int P1U4Health;

    public int P2U1Health;
    public int P2U2Health;
    public int P2U3Health;
    public int P2U4Health;

    public GameObject[] P1lines = new GameObject[4];
    public GameObject[] P2lines = new GameObject[4];

    // Use this for initialization
    void Start()
    {
        P1U1Health = 2;
        P1U2Health = 2;
        P1U3Health = 2;
        P1U4Health = 2;

        P2U1Health = 2;
        P2U2Health = 2;
        P2U3Health = 2;
        P2U4Health = 2;

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
        turnOne = false;
        turnTwo = false;
        turnThree = false;
        turnFour = false;
        turnReset = false;

        P2UnitOne.SetActive(false);
        P2turnOne = false;
        P2turnTwo = false;
        P2turnThree = false;
        P2turnFour = false;
        P2turnReset = false;


    }

    public void Update()
    {
        P1U1Dead = healthManager.GetComponent<HealthManager>().P1U1Dead;
        P1U2Dead = healthManager.GetComponent<HealthManager>().P1U2Dead;
        P1U3Dead = healthManager.GetComponent<HealthManager>().P1U3Dead;
        P1U4Dead = healthManager.GetComponent<HealthManager>().P1U4Dead;

        P2U1Dead = healthManager.GetComponent<HealthManager>().P2U1Dead;
        P2U2Dead = healthManager.GetComponent<HealthManager>().P2U2Dead;
        P2U3Dead = healthManager.GetComponent<HealthManager>().P2U3Dead;
        P2U4Dead = healthManager.GetComponent<HealthManager>().P2U4Dead;

        //Player One
        if (P1Turn == 1)
        {
            GreenOppo.SetActive(true);

            if (P1U1Dead == true)
            {
                turnOne = true;
            }

            else if ((Input.GetKeyDown("joystick 1 button 0")) && P2U1Dead == false)
            {
                turnOne = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u1st.transform.position));
                lRend.SetPosition(1, (p2u1tr.transform.position));
                P1lines[0] = newLine;
                P2U1Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 1")) && P2U2Dead == false)
            {
                turnOne = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u1st.transform.position));
                lRend.SetPosition(1, (p2u2tr.transform.position));
                P1lines[0] = newLine;
                P2U2Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 2")) && P2U3Dead == false)
            {
                turnOne = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u1st.transform.position));
                lRend.SetPosition(1, (p2u3tr.transform.position));
                P1lines[0] = newLine;
                P2U3Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 3")) && P2U4Dead == false)
            {
                turnOne = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u1st.transform.position));
                lRend.SetPosition(1, (p2u4tr.transform.position));
                P1lines[0] = newLine;
                P2U4Health -= 1;
            }
        }


        if (P1Turn == 2)
        {
            GreenOppo.SetActive(true);

            if (P1U2Dead == true)
            {
                turnTwo = true;
            }

            else if ((Input.GetKeyDown("joystick 1 button 0")) && P2U1Dead == false)
            {
                turnTwo = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u2st.transform.position));
                lRend.SetPosition(1, (p2u1tr.transform.position));
                P1lines[1] = newLine;
                P2U1Health -= 1;

            }

            else if ((Input.GetKeyDown("joystick 1 button 1")) && P2U2Dead == false)
            {
                turnTwo = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u2st.transform.position));
                lRend.SetPosition(1, (p2u2tr.transform.position));
                P1lines[1] = newLine;
                P2U2Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 2")) && P2U3Dead == false)
            {
                turnTwo = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u2st.transform.position));
                lRend.SetPosition(1, (p2u3tr.transform.position));
                P1lines[1] = newLine;
                P2U3Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 3")) && P2U4Dead == false)
            {
                turnTwo = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u2st.transform.position));
                lRend.SetPosition(1, (p2u4tr.transform.position));
                P1lines[1] = newLine;
                P2U4Health -= 1;
            }
        }

        if (P1Turn == 3)
        {
            GreenOppo.SetActive(true);

            if (P1U3Dead == true)
            {
                turnThree = true;
            }

            else if ((Input.GetKeyDown("joystick 1 button 0")) && P2U1Dead == false)
            {
                turnThree = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u3st.transform.position));
                lRend.SetPosition(1, (p2u1tr.transform.position));
                P1lines[2] = newLine;
                P2U1Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 1")) && P2U2Dead == false)
            {
                turnThree = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u3st.transform.position));
                lRend.SetPosition(1, (p2u2tr.transform.position));
                P1lines[2] = newLine;
                P2U2Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 2")) && P2U3Dead == false)
            {
                turnThree = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u3st.transform.position));
                lRend.SetPosition(1, (p2u3tr.transform.position));
                P1lines[2] = newLine;
                P2U3Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 3")) && P2U4Dead == false)
            {
                turnThree = true;

                GameObject newLine = Instantiate(p1LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u3st.transform.position));
                lRend.SetPosition(1, (p2u4tr.transform.position));
                P1lines[2] = newLine;
                P2U4Health -= 1;
            }
        }

        if (P1Turn == 4)
        {
            GreenAlly.SetActive(true);
            if (P1U4Dead == true)
            {
                turnFour = true;
            }

            else if ((Input.GetKeyDown("joystick 1 button 0")) && P1U1Dead == false)
            {
                turnFour = true;

                GameObject newLine = Instantiate(p1DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u4st.transform.position));
                lRend.SetPosition(1, (p1_4t1.transform.position));
                lRend.SetPosition(2, (p1u1tr.transform.position));
                P1lines[3] = newLine;
                P1U1Health += 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 1")) && P1U2Dead == false)
            {
                turnFour = true;

                GameObject newLine = Instantiate(p1DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u4st.transform.position));
                lRend.SetPosition(1, (p1_4t2.transform.position));
                lRend.SetPosition(2, (p1u2tr.transform.position));
                P1lines[3] = newLine;
                P1U2Health += 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 2")) && P1U3Dead == false)
            {
                turnFour = true;

                GameObject newLine = Instantiate(p1DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u4st.transform.position));
                lRend.SetPosition(1, (p1_4t3.transform.position));
                lRend.SetPosition(2, (p1u3tr.transform.position));
                P1lines[3] = newLine;
                P1U3Health += 1;
            }

            else if ((Input.GetKeyDown("joystick 1 button 3")) && P1U4Dead == false)
            {
                turnFour = true;

                GameObject newLine = Instantiate(p1DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p1u4st.transform.position));
                lRend.SetPosition(1, (p1_4t4.transform.position));
                lRend.SetPosition(2, (p1u4tr.transform.position));
                P1lines[3] = newLine;
                P1U4Health += 1;
            }
        }

            if (turnOne)
            {
                P1UnitOne.SetActive(true);
                P1UnitTwo.SetActive(false);
                P1Turn += 1;
                turnOne = false;
                GreenOppo.SetActive(false);
            }

            if (turnTwo)
            {
                P1UnitTwo.SetActive(true);
                P1UnitThree.SetActive(false);
                P1Turn += 1;
                turnTwo = false;
                GreenOppo.SetActive(false);
            }

            if (turnThree)
            {
                P1UnitThree.SetActive(true);
                P1UnitFour.SetActive(false);
                P1Turn += 1;
                turnThree = false;
                GreenOppo.SetActive(false);
            }

            if (turnFour)
            {
                P1UnitFour.SetActive(true);
                P1Turn += 1;
                turnFour = false;
                GreenAlly.SetActive(false);
            }

        //Player Two
        if (P2Turn == 1)
        {
            PurpleOppo.SetActive(true);

            if (P2U1Dead == true)
            {
                P2turnOne = true;
            }

            else if ((Input.GetKeyDown("joystick 2 button 0")) && P1U1Dead == false)
            {
                P2turnOne = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u1st.transform.position));
                lRend.SetPosition(1, (p1u1tr.transform.position));
                P2lines[0] = newLine;
                P1U1Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 1")) && P1U2Dead == false)
            {
                P2turnOne = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u1st.transform.position));
                lRend.SetPosition(1, (p1u2tr.transform.position));
                P2lines[0] = newLine;
                P1U2Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 2")) && P1U3Dead == false)
            {
                P2turnOne = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u1st.transform.position));
                lRend.SetPosition(1, (p1u3tr.transform.position));
                P2lines[0] = newLine;
                P1U3Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 3")) && P1U4Dead == false)
            {
                P2turnOne = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u1st.transform.position));
                lRend.SetPosition(1, (p1u4tr.transform.position));
                P2lines[0] = newLine;
                P1U4Health -= 1;
            }
        }


        if (P2Turn == 2)
        {
            PurpleOppo.SetActive(true);

            if (P2U2Dead == true)
            {
                P2turnTwo = true;
            }

            else if ((Input.GetKeyDown("joystick 2 button 0")) && P1U1Dead == false)
            {
                P2turnTwo = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u2st.transform.position));
                lRend.SetPosition(1, (p1u1tr.transform.position));
                P2lines[1] = newLine;
                P1U1Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 1")) && P1U2Dead == false)
            {
                P2turnTwo = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u2st.transform.position));
                lRend.SetPosition(1, (p1u2tr.transform.position));
                P2lines[1] = newLine;
                P1U2Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 2")) && P1U3Dead == false)
            {
                P2turnTwo = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u2st.transform.position));
                lRend.SetPosition(1, (p1u3tr.transform.position));
                P2lines[1] = newLine;
                P1U3Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 3")) && P1U4Dead == false)
            {
                P2turnTwo = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u2st.transform.position));
                lRend.SetPosition(1, (p1u4tr.transform.position));
                P2lines[1] = newLine;
                P1U4Health -= 1;
            }
        }

        if (P2Turn == 3)
        {
            PurpleOppo.SetActive(true);

            if (P2U3Dead == true)
            {
                P2turnThree = true;
            }

            else if ((Input.GetKeyDown("joystick 2 button 0")) && P1U1Dead == false)
            {
                P2turnThree = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u3st.transform.position));
                lRend.SetPosition(1, (p1u1tr.transform.position));
                P2lines[2] = newLine;
                P1U1Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 1")) && P1U2Dead == false)
            {
                P2turnThree = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u3st.transform.position));
                lRend.SetPosition(1, (p1u2tr.transform.position));
                P2lines[2] = newLine;
                P1U2Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 2")) && P1U3Dead == false)
            {
                P2turnThree = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u3st.transform.position));
                lRend.SetPosition(1, (p1u3tr.transform.position));
                P2lines[2] = newLine;
                P1U3Health -= 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 3")) && P1U4Dead == false)
            {
                P2turnThree = true;

                GameObject newLine = Instantiate(p2LineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u3st.transform.position));
                lRend.SetPosition(1, (p1u4tr.transform.position));
                P2lines[2] = newLine;
                P1U4Health -= 1;
            }
        }

        if (P2Turn == 4)
        {
            PurpleAlly.SetActive(true);

            if (P2U4Dead == true)
            {
                P2turnFour = true;
            }

            if ((Input.GetKeyDown("joystick 2 button 0")) && P2U1Dead == false)
            {
                P2turnFour = true;

                GameObject newLine = Instantiate(p2DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u4st.transform.position));
                lRend.SetPosition(1, (p2_4t1.transform.position));
                lRend.SetPosition(2, (p2u1tr.transform.position));
                P2lines[3] = newLine;
                P2U1Health += 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 1")) && P2U2Dead == false)
            {
                P2turnFour = true;

                GameObject newLine = Instantiate(p2DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u4st.transform.position));
                lRend.SetPosition(1, (p2_4t2.transform.position));
                lRend.SetPosition(2, (p2u2tr.transform.position));
                P2lines[3] = newLine;
                P2U2Health += 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 2")) && P2U3Dead == false)
            {
                P2turnFour = true;

                GameObject newLine = Instantiate(p2DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u4st.transform.position));
                lRend.SetPosition(1, (p2_4t3.transform.position));
                lRend.SetPosition(2, (p2u3tr.transform.position));
                P2lines[3] = newLine;
                P2U3Health += 1;
            }

            else if ((Input.GetKeyDown("joystick 2 button 3")) && P2U4Dead == false)
            {
                P2turnFour = true;

                GameObject newLine = Instantiate(p2DblLineMaker);
                LineRenderer lRend = newLine.GetComponent<LineRenderer>();
                lRend.SetPosition(0, (p2u4st.transform.position));
                lRend.SetPosition(1, (p2_4t4.transform.position));
                lRend.SetPosition(2, (p2u4tr.transform.position));
                P2lines[3] = newLine;
                P2U4Health += 1;
            }
        }

        if (P2turnOne)
            {
                P2UnitOne.SetActive(true);
                P2UnitTwo.SetActive(false);
                P2Turn += 1;
                P2turnOne = false;
                PurpleOppo.SetActive(false);
            }

        if (P2turnTwo)
            {
                P2UnitTwo.SetActive(true);
                P2UnitThree.SetActive(false);
                P2Turn += 1;
                P2turnTwo = false;
                PurpleOppo.SetActive(false);
            }

        if (P2turnThree)
            {
                P2UnitThree.SetActive(true);
                P2UnitFour.SetActive(false);
                P2Turn += 1;
                P2turnThree = false;
                PurpleOppo.SetActive(false);
            }

        if (P2turnFour)
            {
                P2UnitFour.SetActive(true);
                P2Turn += 1;
                P2turnFour = false;
                PurpleAlly.SetActive(false);
            }
    }

    public void NewTurnReset()
    {
        P1UnitOne.SetActive(false);
        P2UnitOne.SetActive(false);
        foreach (GameObject P1Line in P1lines)
        {
            GameObject.Destroy(P1Line);
        }

        foreach (GameObject P2Line in P2lines)
        {
            GameObject.Destroy(P2Line);
        }
    }
}

