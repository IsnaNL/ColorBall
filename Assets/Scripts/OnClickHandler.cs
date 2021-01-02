using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class OnClickHandler : MonoBehaviour
{
    public GameManager gm;
    public Transform pc;
    public TextMeshProUGUI text;
    private int stateCounter;
    //  public List<MeshButton> meshButtons;
    //public List<Material> LitMaterials;

    // Start is called before the first frame update
    /*public  void RecieveClicks(MeshButton b)
    {
        if (b == meshButtons[0])
        {
            RedClicked();
        }
        else if (b == meshButtons[1])
        {
            GreenClicked();
        }
        else if (b == meshButtons[2])
        {
            BlueClicked();
        }
    }*/
    public void Start()
    {
        stateCounter = 0;
        SwitchState();
    }
    private void Update()
    {
        GetInput();
     
    }
    public void RedClicked()
    {
        gm.isRed = true;
        gm.isGreen = false;
        gm.isBlue = false;
        gm.SetColor();


    }
    public void GreenClicked()
    {
        gm.isGreen = true;
        gm.isRed = false;
        gm.isBlue = false;
        gm.SetColor();

    }
    public void BlueClicked()
    {
        gm.isBlue = true;
        gm.isGreen = false;
        gm.isRed = false;
        gm.SetColor();
    }
    void GetInput()
    {
        // Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        // Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
       
        if (Input.touchCount > 0)
        {
            Touch touch =  Input.GetTouch(0);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
           // Vector3 worldSpacePoint =  Camera.main.ScreenToWorldPoint();
                if (touch.position.x >= 530)
                {
                    text.text = touch.position.x.ToString("F");
                    stateCounter++;
                    if (stateCounter > 2)
                    {
                        stateCounter = 0;
                    }
                    SwitchState();
                }
                else
                {
                    stateCounter--;
                    text.text = touch.position.x.ToString("F");
                    if (stateCounter < 0)
                    {
                        stateCounter = 2;
                    }
                    SwitchState();
                }
            }

          
        }
    }
    void SwitchState()
    {
        Debug.Log(stateCounter);
        switch (stateCounter)
        {
            case 0:
                RedClicked();
                break;
            case 1:
                GreenClicked();
                break;
            case 2:
                BlueClicked();
                break;
        }
    }
    
}
