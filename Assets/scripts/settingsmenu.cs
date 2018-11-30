using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour
{
    public AudioMixer audionMixer;
    public void SetVolume(float volume)
    {
        audionMixer.SetFloat("Volume", volume);
    }
}
