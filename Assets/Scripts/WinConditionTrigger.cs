using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionTrigger : MonoBehaviour
{
    public GameManager gm;
    public List<ParticleSystem> particles;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        gm.StartCoroutine(gm.EndLevelWon());
        gm.LevelOver = true;
        AudioManager.a_Instance.PlayWinGameClip();
        foreach(ParticleSystem p in particles)
        {

            //p.transform.parent = null;
            p.gameObject.SetActive(true);
            p.Play();
        }
    }
}
