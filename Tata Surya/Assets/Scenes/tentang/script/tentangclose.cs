using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tentangclose : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioClip click;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void ClickSound()
    {
        buttonSound.PlayOneShot(click);
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
