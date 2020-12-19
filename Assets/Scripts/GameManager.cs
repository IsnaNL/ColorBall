using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Material> matList;
    public GameObject Sphere;
    public MeshRenderer sphereMr;
    public int redLayer;
    public int GreenLayer;
    public int blueLayer;
    public bool isRed;
    public bool isGreen;
    public bool isBlue;


    public enum CurrentColor
    {
        red,
        green,
        blue,
    }
    public CurrentColor color;
    public void Start()
    {
        sphereMr = Sphere.GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update

    public void SetColor()
    {
        if (isRed)
        {
            color = CurrentColor.red;
            isGreen = false;
            isBlue = false;
            Sphere.layer = redLayer;
            sphereMr.material = matList[0];
        }
        if (isGreen)
        {
            color = CurrentColor.green;
            isRed = false;
            isBlue = false;
            Sphere.layer = GreenLayer;
            sphereMr.material = matList[1];
        }
        if (isBlue)
        {
            color = CurrentColor.blue;
            isRed = false;
            isGreen = false;
            Sphere.layer = blueLayer;
            sphereMr.material = matList[2];

        }
       /* switch (color)
        {
            case CurrentColor.red:
               
                break;
            case CurrentColor.green:
               
                break;
            case CurrentColor.blue:
                
                break;
        }*/

    }
}
