using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpLevel : MonoBehaviour
{
    public float LevelMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, LevelMoveSpeed * Time.deltaTime, 0);
    }
}
