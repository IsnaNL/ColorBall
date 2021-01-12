using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassObsTrigger : MonoBehaviour
{
    public int[] layers;
    public ParticleSystem[] passObsParticals;
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == layers[0])
        {
            passObsParticals[0].transform.position = transform.position;
            passObsParticals[0].Play();
        }
        else if(other.gameObject.layer == layers[1])
        {

            passObsParticals[1].transform.position = transform.position;
            passObsParticals[1].Play();
        }
        else if (other.gameObject.layer == layers[2])
        {
            passObsParticals[2].transform.position = transform.position;
            passObsParticals[2].Play();
        }
        AudioManager.a_Instance.PlayRandomPassObsClip();

    }
}
