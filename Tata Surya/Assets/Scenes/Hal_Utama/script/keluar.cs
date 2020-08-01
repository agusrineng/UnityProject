using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keluar : MonoBehaviour
{
    public AudioSource buttonsound;
    public AudioClip Click;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void ExitGame()
    {
        UnityEngine.Debug.LogError("Exit Game");
        Application.Quit();
    }

    public void Clicksound()
    {
        buttonsound.PlayOneShot(Click);
    }
}
