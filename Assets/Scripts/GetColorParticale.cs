using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColorParticale : MonoBehaviour
{
    public GameManager gm;
    public GameObject[] pSArray;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {

        if (gm.isRed)
        {
            pSArray[0].SetActive(true);
            pSArray[1].SetActive(false);
            pSArray[2].SetActive(false);

        }
        else if (gm.isGreen)
        {
            pSArray[0].SetActive(false);
            pSArray[1].SetActive(true);
            pSArray[2].SetActive(false);
        }
        else if (gm.isBlue)
        {

            pSArray[0].SetActive(false);
            pSArray[1].SetActive(false);
            pSArray[2].SetActive(true);
        }

    }
}
