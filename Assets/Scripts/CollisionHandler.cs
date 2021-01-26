using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameManager gm;
    //public int[] ColorLayers = new int[3];
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer != this.gameObject.layer)
        {
            this.gameObject.SetActive(false);
            gm.StartCoroutine(gm.EndLevelLost());
            AudioManager.a_Instance.PlayRandomLoseClip();
        }
        
      
    }
}
