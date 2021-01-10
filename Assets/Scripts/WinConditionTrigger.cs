using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionTrigger : MonoBehaviour
{
    public GameManager gm;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        gm.StartCoroutine(gm.EndLevel());
        gm.LevelOver = true;
    }
}
