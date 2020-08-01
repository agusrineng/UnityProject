using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawab : MonoBehaviour
{

    public AudioSource buttonSound;
    public AudioClip click;
    public GameObject feed_benar, feed_salah;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void ClickSound()
    {
        buttonSound.PlayOneShot(click);
    }

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor") + 10;
            PlayerPrefs.SetInt("skor", skor);
        }
        else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }

        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
