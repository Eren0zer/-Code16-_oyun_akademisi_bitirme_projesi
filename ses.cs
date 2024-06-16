using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioSource audioSource; // Ses kaynaðý
    public AudioClip soundEffect; // Çalýnacak ses dosyasý


    public AudioSource audioSource2; // Ses kaynaðý
    public AudioClip soundEffect2; // Çalýnacak ses dosyasý

    private bool isSoundPlaying = false;

    void Start()
    {
        // Eðer audioSource atanmamýþsa, bu scripti içeren GameObject'te bulunan bir AudioSource bileþeni arayýn
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        // Eðer audioSource atanmamýþsa, bu scripti içeren GameObject'te bulunan bir AudioSource bileþeni arayýn
        if (audioSource2 == null)
        {
            audioSource2 = GetComponent<AudioSource>();
        }
    }
    public void PlaySound()
    {
        // Ses dosyasýný çal
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
        // Ses dosyasýný çal
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
        // Ses dosyasýný durdur
        if (audioSource2 != null)
        {
            audioSource2.Stop();
            isSoundPlaying = false;
        }
    }


}