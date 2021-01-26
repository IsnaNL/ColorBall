using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuoPlatform : MonoBehaviour
{
    public List<GameObject> platforms;
    public float platfromSpeed;
    private float dissapearX;
    private float AppearX;
    public bool isMoveRight; 
    // Start is called before the first frame update
    void Start()
    {
       //these are localPosition Xs
        dissapearX = isMoveRight ? 30.2f : -9.62f; 
        AppearX = isMoveRight ? -9.62f : 30.2f;
    }

    // Update is called once per frame
    void Update()
    {
       
        foreach(GameObject p in platforms)
        {
            p.transform.Translate(platfromSpeed * Time.deltaTime, 0, 0);
            if (isMoveRight)
            {
                if (p.transform.localPosition.x >= dissapearX)
                {
                    p.transform.localPosition = new Vector3(AppearX, p.transform.localPosition.y, p.transform.localPosition.z);
                }
            }
            else
            {
                if (p.transform.localPosition.x <= dissapearX)
                {
                    p.transform.localPosition = new Vector3(AppearX, p.transform.localPosition.y, p.transform.localPosition.z);
                }
            }
          
        }
    }
}
