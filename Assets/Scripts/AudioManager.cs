using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager a_Instance;
    public AudioClip passObsClips;
    public List<AudioClip> loseClips;
    public AudioClip startGameClip;
    public AudioClip WinGameClip;
    public AudioClip thisIsNotADreamClip;
    public AudioClip changeColorClip;
    public AudioClip MainMenuMusic;
    public AudioSource audioSource;
    public void Start()
    {
        a_Instance = this;
    }
    public void MainMenuAmbience()
    {
        audioSource.volume = Settings.isSoundOn ? 0.5f : 0;
        audioSource.Play();
    }
    public void PlayRandomLoseClip()
    {
        audioSource.volume =  Settings.isSoundOn ? 0.3f : 0;
        audioSource.PlayOneShot(loseClips[Random.Range(0, loseClips.Count)]);
    }
    public void PlayPassObsClip()
    {

       audioSource.volume = Settings.isSoundOn ? 0.1f : 0;
        audioSource.PlayOneShot(passObsClips);
    }
    public void PlayStartGameClip()
    {
        audioSource.volume = Settings.isSoundOn ? 0.3f : 0;

        audioSource.PlayOneShot(startGameClip);
       


    }
    public void PlayWinGameClip()
    {
        audioSource.volume = Settings.isSoundOn ? 0.3f : 0;
        audioSource.PlayOneShot(WinGameClip);

    }
    public void PlaythisIsNotADream()
    {
        audioSource.volume = Settings.isSoundOn ? 0.4f : 0;
        audioSource.PlayOneShot(thisIsNotADreamClip);

    }
    public void PlayChangeColor()
    {
        audioSource.volume = Settings.isSoundOn ? 0.07f : 0;
        audioSource.PlayOneShot(changeColorClip);
    }
    public void SetVolumeZero()
    {
        audioSource.volume = 0;
    }
}
