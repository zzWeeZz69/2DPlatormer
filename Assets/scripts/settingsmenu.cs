using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour
{
    public AudioMixer audionMixer;

    // tar audioMixern och ger den floaten av volume
    public void SetVolume(float volume)
    {
        audionMixer.SetFloat("Volume", volume);
    }
}
