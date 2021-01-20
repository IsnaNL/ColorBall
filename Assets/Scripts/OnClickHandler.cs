using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class OnClickHandler : MonoBehaviour
{
    public GameManager gm;
    public Transform pc;
    public TextMeshProUGUI text;
    private int stateCounter = 2;
    public GameObject ObjectToInstantiate;
    private bool isRightClicked;
    private enum State{
        greenRedBlue,
        greenBlueRed,
        blueRedGreen,
        blueGreenRed,
        redBlueGreen,
        redGreenBlue,
        }
    private State state;

    private void Start()
    {
        SwitchState();
    }

    private void Update()
    {
        GetInput();

    }
  
    void greenRedBlueState()
    {
        if (isRightClicked)
        {
            gm.SetColor(1);
            state = State.greenBlueRed;
        }
        else
        {
            gm.SetColor(5);
            state = State.redGreenBlue;
        }
    }
    void greenBlueRedState()
    {
        if (isRightClicked)
        {
            gm.SetColor(0);
            state = State.greenRedBlue;

        }
        else
        {
            gm.SetColor(3);
            state = State.blueGreenRed;
        }
    }
    void blueRedGreenState()
    {
        if (isRightClicked)
        {
            gm.SetColor(3);
            state = State.blueGreenRed;
        }
        else
        {
            gm.SetColor(4);
            state = State.redBlueGreen;
        }
    }
    void blueGreenRedState()
    {
        if (isRightClicked)
        {
            gm.SetColor(2);
            state = State.blueRedGreen;

        }
        else
        {
            gm.SetColor(1);
            state = State.greenBlueRed;

        }

    }
    void redBlueGreenState()
    {
        if (isRightClicked)
        {
            gm.SetColor(5);
            state = State.redGreenBlue;
        }
        else
        {
            gm.SetColor(2);
            state = State.blueRedGreen;
        }

    }
    void redGreenBlueState()
    {
        if (isRightClicked)
        {
            gm.SetColor(4);
            state = State.redBlueGreen;
        }
        else
        {
            gm.SetColor(0);
            state = State.greenRedBlue;

        }

    }
    void GetInput()
    {
       
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
    
            AudioManager.a_Instance.PlayChangeColor();
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                isRightClicked = true;
                SwitchState();

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                isRightClicked = false;
                SwitchState();
            }
        }

        if (Input.touchCount > 0)//TouchControls
        {
          
            Touch touch = Input.GetTouch(0);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                int lastState = stateCounter;
                AudioManager.a_Instance.PlayChangeColor();
                if (touch.position.x >= (Screen.width / 2))
                {

                    isRightClicked = true;
                    SwitchState();
                }
                else
                {

                    isRightClicked = false;
                    SwitchState();

                }
            }
   
        }
       

    }
    void SwitchState()
    {
       
        Debug.Log(gm.lastColor);
        Debug.Log(stateCounter);
        switch (state)
        {
            case State.greenRedBlue:
                greenRedBlueState();
                break;
            case State.greenBlueRed:
                greenBlueRedState();
                break;
            case State.blueRedGreen:
                blueRedGreenState();
                break;
            case State.blueGreenRed:
                blueGreenRedState();
                break;
            case State.redBlueGreen:
                redBlueGreenState();
                break;
            case State.redGreenBlue:
                redGreenBlueState();
                break;

        }
    }
}
