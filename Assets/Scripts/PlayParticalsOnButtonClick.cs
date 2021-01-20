using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayParticalsOnButtonClick : MonoBehaviour
{
    public Button btn;
    public ParticleSystem[] particals;
   
    void Start()
    {
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        foreach (ParticleSystem p in particals)
        {
            p.gameObject.SetActive(true);
            p.Play();
        }
    }
  
   
}
