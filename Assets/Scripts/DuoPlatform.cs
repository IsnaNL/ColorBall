using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuoPlatform : MonoBehaviour
{
    public List<GameObject> platforms;
    public float platfromSpeed;
    private float dissapearX;
    private float AppearX;
    // Start is called before the first frame update
    void Start()
    {
        dissapearX = -9.62f;
        AppearX = 30.2f;
    }

    // Update is called once per frame
    void Update()
    {
       
        foreach(GameObject p in platforms)
        {
            p.transform.Translate(platfromSpeed * Time.deltaTime, 0, 0);
            if (p.transform.localPosition.x <= dissapearX)
            {
                p.transform.localPosition = new Vector3(AppearX, p.transform.localPosition.y, p.transform.localPosition.z);
            }
        }
    }
}
