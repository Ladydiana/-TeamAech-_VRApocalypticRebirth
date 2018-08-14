using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

    [SerializeField]
    private AudioMixerSnapshot apocalypticSnap;
    [SerializeField]
    private AudioMixerSnapshot natureSnap;
    [SerializeField]
    private AudioMixerSnapshot scifiSnap;
    [SerializeField]
    private AudioMixerSnapshot kingdomSnap;
    [SerializeField]
    private AudioMixerSnapshot factorySnap;
    [SerializeField]
    private AudioSource natureAudioSource;
    [SerializeField]
    private AudioSource scifiAudioSource;
    [SerializeField]
    private AudioSource kingdomAudioSource;
    [SerializeField]
    private AudioSource factoryAudioSource;

    public void ChangeToNature()
    {
        natureSnap.TransitionTo(1);
        natureAudioSource.PlayDelayed(1);
        natureAudioSource.loop = true;
    }

    public void ChangeToScifi()
    {
        scifiSnap.TransitionTo(1);
        scifiAudioSource.PlayDelayed(1);
        scifiAudioSource.loop = true;
    }

    public void ChangeToKingdom()
    {
        kingdomSnap.TransitionTo(1);
        kingdomAudioSource.PlayDelayed(1);
        kingdomAudioSource.loop = true;
    }

    public void ChangeToFactory()
    {
        factorySnap.TransitionTo(1);
        factoryAudioSource.PlayDelayed(1);
        factoryAudioSource.loop = true;
    }



    public void RestartAudio()
    {
        apocalypticSnap.TransitionTo(1);
    }
}
