using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    [SerializeField] public AudioSource buttonSFX;
    [SerializeField] public AudioClip clickSFX;
    [SerializeField] public AudioClip hoverSFX;

    public void OnEnable()
    {
        buttonSFX = GetComponent<AudioSource>();
    }

    public void PlayClickSFX()
    {
        buttonSFX.PlayOneShot(clickSFX);
    }

    public void PlayHoverSFX()
    {
        buttonSFX.PlayOneShot(hoverSFX);
    }
}
