using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralHubAudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    AudioSource audioSource;
    [Header("Each audio clip")]
    //One possibility
    [Header("Four Instruments")]
    [SerializeField]
    AudioClip FluteGuitarDrumsViolin;
    [SerializeField]
    [Header("Two Instruments")]
    AudioClip FluteGuitar;
    [SerializeField]
    AudioClip FluteDrums;
    [SerializeField]
    AudioClip FluteViolin;
    [SerializeField]
    AudioClip GuitarDrums;
    [SerializeField]
    AudioClip GuitarViolin;
    [SerializeField]
    AudioClip DrumsViolin;
    [Header("Three Instruments")]
    [SerializeField]
    AudioClip FluteGuitarDrums;
    [SerializeField]
    AudioClip FluteGuitarViolin;
    [SerializeField]
    AudioClip FluteDrumsViolin;
    [SerializeField]
    AudioClip GuitarDrumsViolin;
    [Header("One Instrument")]
    [SerializeField]
    AudioClip Drums;
    [SerializeField]
    AudioClip Guitar;
    [SerializeField]
    AudioClip Flute;
    [SerializeField]
    AudioClip Violin;
    [Header("No instruments unlocked")]
    [SerializeField]
    AudioClip desolateClip;


    void Start()
    {
        //one possibility
        if (gameManager.FluteEnabled && gameManager.GuitarEnabled && gameManager.DrumsEnabled && gameManager.DrumsEnabled)
        {
            audioSource.clip = FluteGuitarDrumsViolin;
        }
        //three possibilities
        else if (gameManager.FluteEnabled && gameManager.GuitarEnabled && gameManager.DrumsEnabled)
        {
            audioSource.clip = FluteGuitarDrums;
        }
        else if (gameManager.FluteEnabled && gameManager.GuitarEnabled && gameManager.ViolinEnabled)
        {
            audioSource.clip = FluteGuitarViolin;
        }
        else if (gameManager.FluteEnabled && gameManager.DrumsEnabled && gameManager.ViolinEnabled)
        {
            audioSource.clip = FluteDrumsViolin;
        }
        else if (gameManager.GuitarEnabled && gameManager.DrumsEnabled && gameManager.ViolinEnabled)
        {
            audioSource.clip = GuitarDrumsViolin;
        }
        //two possibilties
        else if (gameManager.FluteEnabled && gameManager.GuitarEnabled)//1
        {
            audioSource.clip = FluteGuitar;
        }
        else if (gameManager.FluteEnabled && gameManager.DrumsEnabled)//2
        {
            audioSource.clip = FluteDrums;
        }
        else if (gameManager.FluteEnabled && gameManager.ViolinEnabled)//3
        {
            audioSource.clip = FluteViolin;
        }
        else if (gameManager.GuitarEnabled && gameManager.DrumsEnabled)// 4
        {
            audioSource.clip = GuitarDrums;
        }
        else if (gameManager.GuitarEnabled && gameManager.ViolinEnabled)// 5
        {
            audioSource.clip = GuitarViolin;
        }
        else if (gameManager.DrumsEnabled && gameManager.ViolinEnabled)// 5
        {
            audioSource.clip = DrumsViolin;
        }
        else if (gameManager.DrumsEnabled)
        {
            audioSource.clip = Drums;
        }
        else if (gameManager.GuitarEnabled)
        {
            audioSource.clip = Guitar;
        }
        else if (gameManager.FluteEnabled)
        {
            audioSource.clip = Flute;
        }
        else if (gameManager.ViolinEnabled)
        {
            audioSource.clip = Violin;
        }
        else
        {
            audioSource.clip = desolateClip;
        }

    }

   
}
