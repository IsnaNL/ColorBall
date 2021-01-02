using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Material> matList;
    public GameObject Sphere;
    private MeshRenderer sphereMR;
    public MeshRenderer nextColorIndicator;
    public MeshRenderer previousColorIndicator;
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
        sphereMR = Sphere.GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    public void EndLevel()
    {
        Debug.Log("you have finished the level gj");
    }
    public void SetColor()
    {
        if (isRed)
        {
            color = CurrentColor.red;
            isGreen = false;
            isBlue = false;
            Sphere.layer = redLayer;
            sphereMR.material = matList[0];
            previousColorIndicator.material = matList[2];
            nextColorIndicator.material = matList[1];

        }
        if (isGreen)
        {
            color = CurrentColor.green;
            isRed = false;
            isBlue = false;
            Sphere.layer = GreenLayer;
            sphereMR.material = matList[1];
            previousColorIndicator.material = matList[0];
            nextColorIndicator.material = matList[2];
        }
        if (isBlue)
        {
            color = CurrentColor.blue;
            isRed = false;
            isGreen = false;
            Sphere.layer = blueLayer;
            sphereMR.material = matList[2];
            previousColorIndicator.material = matList[1];
            nextColorIndicator.material = matList[0];

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
