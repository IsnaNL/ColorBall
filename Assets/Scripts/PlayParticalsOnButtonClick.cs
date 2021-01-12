using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayParticalsOnButtonClick : MonoBehaviour
{
    public Button btn;
    public ParticleSystem[] particals;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        foreach (ParticleSystem p in particals)
        {
            p.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
