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
    public AudioSource audioSource;
    public void Start()
    {
        a_Instance = this;
    }
    // Start is called before the first frame update
    public void PlayRandomLoseClip()
    {
        audioSource.volume = 0.3f;
        audioSource.PlayOneShot(loseClips[Random.Range(0, loseClips.Count)]);
    }
    public void PlayRandomPassObsClip()
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
}
