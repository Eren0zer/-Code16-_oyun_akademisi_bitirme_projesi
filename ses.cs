using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioSource audioSource; // Ses kayna��
    public AudioClip soundEffect; // �al�nacak ses dosyas�


    public AudioSource audioSource2; // Ses kayna��
    public AudioClip soundEffect2; // �al�nacak ses dosyas�

    private bool isSoundPlaying = false;

    void Start()
    {
        // E�er audioSource atanmam��sa, bu scripti i�eren GameObject'te bulunan bir AudioSource bile�eni aray�n
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        // E�er audioSource atanmam��sa, bu scripti i�eren GameObject'te bulunan bir AudioSource bile�eni aray�n
        if (audioSource2 == null)
        {
            audioSource2 = GetComponent<AudioSource>();
        }
    }
    public void PlaySound()
    {
        // Ses dosyas�n� �al
        if (soundEffect != null && audioSource != null)
        {
            audioSource.PlayOneShot(soundEffect);
        }
    }

  

    public void ToggleSound()
    {
        if (isSoundPlaying)
        {
            StopSound();
        }
        else
        {
            PlaySound1();
        }
    }

    public void PlaySound1()
    {
        // Ses dosyas�n� �al
        if (soundEffect2 != null && audioSource2 != null)
        {
            audioSource2.clip = soundEffect2;
            audioSource2.loop = true;
            audioSource2.Play();
            isSoundPlaying = true;
        }
    }

    public void StopSound()
    {
        // Ses dosyas�n� durdur
        if (audioSource2 != null)
        {
            audioSource2.Stop();
            isSoundPlaying = false;
        }
    }


}