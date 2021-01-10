using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Material> matList;
    public MeshRenderer player;
    public MeshRenderer NextColorIndicator;
    public MeshRenderer PrevColorIndicator;
    public GameObject PauseMenuHolder;
    public bool LevelOver;
    // public List<MeshRenderer> mRList;

    public int redLayer;
    public int GreenLayer;
    public int blueLayer;
    public bool isRed;
    public bool isGreen;
    public bool isBlue;
    public float waitTimeTillEnd;


    public enum CurrentColor
    {
        red,
        green,
        blue,
    }
    public CurrentColor color;

    public void Start()
    {
        Time.timeScale = 1f;
        LevelOver = false;
        SetColor();
    }
    // Start is called before the first frame update
    public IEnumerator EndLevel()
    {
        Debug.Log("you have finished the level gj");
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds(waitTimeTillEnd);
        PauseMenuHolder.SetActive(true);
    }
    public void SetColor()
    {
        if (isRed)
        {
            color = CurrentColor.red;
            isGreen = false;
            isBlue = false;
            player.gameObject.layer = redLayer;
            player.material = matList[0];
            NextColorIndicator.material = matList[1];
            PrevColorIndicator.material = matList[2];
            /* foreach (MeshRenderer mr in mRList)
             {
                 //mr.material = matList[0];
             }
           */
        }
        if (isGreen)
        {
            color = CurrentColor.green;
            isRed = false;
            isBlue = false;
            player.gameObject.layer = GreenLayer;
            /* foreach (MeshRenderer mr in mRList)
             {
                 //mr.material = matList[1];
             }
            */
            player.material = matList[1];
            NextColorIndicator.material = matList[2];
            PrevColorIndicator.material = matList[0];
        }
        if (isBlue)
         {
             color = CurrentColor.blue;
             isRed = false;
             isGreen = false;
             player.gameObject.layer = blueLayer;
            /*  foreach (MeshRenderer mr in mRList)
              {
                 // mr.material = matList[2];
              }
             */
            player.material = matList[2];
            NextColorIndicator.material = matList[0];
            PrevColorIndicator.material = matList[1];
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
