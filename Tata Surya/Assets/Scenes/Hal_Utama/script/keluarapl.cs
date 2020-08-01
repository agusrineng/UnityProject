using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keluarapl : MonoBehaviour
{
    public AudioSource buttonsound;
    public AudioClip click;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void ClickSound()
    {
        buttonsound.PlayOneShot(click);
    }

    public void KeluarApl()
    {
        UnityEngine.Debug.LogError("Keluar Game");
        Application.Quit();
    }
}
