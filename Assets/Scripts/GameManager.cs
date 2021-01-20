using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Material> matList;
    public MeshRenderer player;
    public MeshRenderer RightColorIndicator;
    public MeshRenderer LeftColorIndicator;
    public GameObject PauseMenuHolder;
    public bool LevelOver;
    public int lastColor;
    public int redLayer;
    public int GreenLayer;
    public int blueLayer;
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
    }
    // Start is called before the first frame update
    public IEnumerator EndLevel()
    {
        Debug.Log("you have finished the level gj");
        Time.timeScale = 0.4f;
        yield return new WaitForSeconds(waitTimeTillEnd);
        PauseMenuHolder.SetActive(true);
    }
    public void SetColor(int state)
    {
        Material[] tempMaterials = new Material[7];
        switch (state)
        {
          
            case 0 :                              
                 
                    for (int m = 0; m < tempMaterials.Length; m++)
                    {
                        tempMaterials[m] = matList[0];

                    }
                    player.materials = tempMaterials;
                    player.gameObject.layer = redLayer;
                    RightColorIndicator.material = matList[2];
                    LeftColorIndicator.material = matList[1];
                    color = CurrentColor.red;
                break;
            case 1:
                    for (int m = 0; m < tempMaterials.Length; m++)
                    {
                        tempMaterials[m] = matList[2];

                    }
                    player.materials = tempMaterials;
                    player.gameObject.layer = blueLayer;
                    RightColorIndicator.material = matList[0];
                    LeftColorIndicator.material = matList[1];
                    color = CurrentColor.blue;

                break;
            case 2:
                
                    for (int m = 0; m < tempMaterials.Length; m++)
                    {
                        tempMaterials[m] = matList[0];

                    }
                    player.materials = tempMaterials;
                    player.gameObject.layer = redLayer;
                    RightColorIndicator.material = matList[1];
                    LeftColorIndicator.material = matList[2];                      
                    color = CurrentColor.red;
                break;
            case 3:
                for (int m = 0; m < tempMaterials.Length; m++)
                {
                    tempMaterials[m] = matList[1];

                }
                player.materials = tempMaterials;
                player.gameObject.layer = GreenLayer;
                RightColorIndicator.material = matList[0];
                LeftColorIndicator.material = matList[2];
                color = CurrentColor.green;
                break;
            case 4:
                for (int m = 0; m < tempMaterials.Length; m++)
                {
                    tempMaterials[m] = matList[2];

                }
                player.materials = tempMaterials;
                player.gameObject.layer = blueLayer;
                RightColorIndicator.material = matList[1];
                LeftColorIndicator.material = matList[0];
                color = CurrentColor.blue;
                break;
              
            case 5:
                for (int m = 0; m < tempMaterials.Length; m++)
                {
                    tempMaterials[m] = matList[1];

                }
                player.materials = tempMaterials;
                player.gameObject.layer = GreenLayer;
                RightColorIndicator.material = matList[2];
                LeftColorIndicator.material = matList[0];
                color = CurrentColor.green;
                break;
        }
       
       
       
    }
    }
