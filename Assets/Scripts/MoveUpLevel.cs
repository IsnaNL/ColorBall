using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpLevel : MonoBehaviour
{
    public float LevelMoveSpeed;

 
    void Update()
    {
        transform.Translate(0, LevelMoveSpeed * Time.deltaTime, 0);
    }
}
