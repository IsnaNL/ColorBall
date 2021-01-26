using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButtonHandler : MonoBehaviour
{

    public Button SoundOn;
    public Button SoundOff;
    public AudioSource BackGroundMusic;


    void Start()
    {
        BackGroundMusic.volume = Settings.isSoundOn ? 0.05f : 0;
        
        SoundOn.gameObject.SetActive(Settings.isSoundOn ? true : false);
        SoundOff.gameObject.SetActive(Settings.isSoundOn ? false : true);
        SoundOn.onClick.AddListener(TaskOnClick);
        SoundOff.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        Settings.isSoundOn = !Settings.isSoundOn;
        if (Settings.isSoundOn)
        {
            SoundOn.gameObject.SetActive(true);
            SoundOff.gameObject.SetActive(false);
            BackGroundMusic.volume = 0.05f;
            

        }
        else
        {
            SoundOn.gameObject.SetActive(false);
            SoundOff.gameObject.SetActive(true);
            BackGroundMusic.volume = 0;
          

        }
        // Start is called before the first frame update

    }
}
