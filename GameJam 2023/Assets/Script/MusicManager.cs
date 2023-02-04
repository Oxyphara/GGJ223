//Teegan Tulk
//Audio Manager that can turn on and off audio, play next the next audio clip, or play an audio clip at Index;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
  
    //AudioSource
    AudioSource audioSource;
    //Audioclips
    [Tooltip("Set each music track in order in which it appears.")]
    [SerializeField]
    AudioClip[] audioClips;
    private int numOfAudioClips;
    private int currentAudioClip;
    
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        numOfAudioClips = audioClips.Length;
    }

    // Update is called once per frame
    public void TurnOffAudio()
    {
        audioSource.Stop();
    }
    public void TurnOnAudio()
    {
        audioSource.Play();
    }
    public void PlayNextAudioClip()
    {
        currentAudioClip++;
        audioSource.clip = audioClips[currentAudioClip];
        audioSource.Play();
    }
    public void PlayAudioClipAtIndex(int inIndex)
    {
        currentAudioClip = inIndex;
        audioSource.clip = audioClips[currentAudioClip];
        audioSource.Play();
    }




}
