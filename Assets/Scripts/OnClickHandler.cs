using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickHandler : MonoBehaviour
{
    public GameManager gm;
    public List<MeshButton> meshButtons;
    //public List<Material> LitMaterials;
   
    // Start is called before the first frame update
    public  void RecieveClicks(MeshButton b)
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
}
