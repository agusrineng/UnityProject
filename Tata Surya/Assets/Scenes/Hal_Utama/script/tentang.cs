using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tentang : MonoBehaviour
{
    public AudioSource buttonsound;
    public AudioClip click;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void scale(float scale)
    {
        transform.localScale = new Vector2(1 / scale, 1 * scale);
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
