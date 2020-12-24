using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public int[] ColorLayers = new int[3];
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == ColorLayers[0]) { this.gameObject.SetActive(false); }
        else if (collision.gameObject.layer == ColorLayers[1]) { this.gameObject.SetActive(false); }
        else if (collision.gameObject.layer == ColorLayers[2]) { this.gameObject.SetActive(false); }
      
    }
}
