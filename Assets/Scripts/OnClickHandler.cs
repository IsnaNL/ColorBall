using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickHandler : MonoBehaviour
{
    public GameManager gm;
    // Start is called before the first frame update
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
}
