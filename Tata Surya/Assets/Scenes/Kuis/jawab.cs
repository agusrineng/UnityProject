using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawab : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioClip click;
    public GameObject feed_benar, feed_salah;
    GameObject gj;
    testingtew ts;
    public bool sudah = false;

    int random;
    // Start is called before the first frame update
    void Start()
    {
        gj = GameObject.Find("keluar");
        ts = gj.GetComponent<testingtew>();
        random = Random.Range(3, 12);
        Application.targetFrameRate = 60;
    }

    public void ClickSound()
    {
        buttonSound.PlayOneShot(click);
    }

    public void jawaban(bool jawab)
    {
        ts.soal++;
        sudah = true;
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
        transform.parent.GetChild(random).gameObject.SetActive(true);
        

    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game Objek = " + gameObject.name);
        if (ts.soal == 10) {
             transform.parent.GetChild(15).gameObject.SetActive(true);
             gameObject.SetActive(false);
        }else if (sudah == true)
        {
            for (int i = 3; i <= 14; i++)
            {
                if (transform.parent.GetChild(i).gameObject.GetComponent<jawab>().sudah == false)
                {
                    transform.parent.GetChild(i).gameObject.SetActive(true);
                    gameObject.SetActive(false);
                    break;
                }
            }

        }
        
    }
}
