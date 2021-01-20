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
    public AudioSource audioSource;
    public void Start()
    {
        a_Instance = this;
    }
  
    public void PlayRandomLoseClip()
    {
        audioSource.volume = 0.3f;
        audioSource.PlayOneShot(loseClips[Random.Range(0, loseClips.Count)]);
    }
    public void PlayPassObsClip()
    {

        audioSource.volume = 0.1f;
        audioSource.PlayOneShot(passObsClips);
    }
    public void PlayStartGameClip()
    {
        audioSource.volume = 0.3f;

        audioSource.PlayOneShot(startGameClip);
       


    }
    public void PlayWinGameClip()
    {
        audioSource.volume = 0.3f;

        audioSource.PlayOneShot(WinGameClip);

    }
    public void PlaythisIsNotADream()
    {
        audioSource.volume = 0.5f;

        audioSource.PlayOneShot(thisIsNotADreamClip);

    }
    public void PlayChangeColor()
    {
        audioSource.volume = 0.08f;

        audioSource.PlayOneShot(changeColorClip);
    }
}
