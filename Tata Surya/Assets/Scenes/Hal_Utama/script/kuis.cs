using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kuis : MonoBehaviour
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

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
