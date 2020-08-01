using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class openpanel : MonoBehaviour
{
    public GameObject PanelKuis;
    public GameObject bt_kuis;
    public GameObject bt_mulaiAR;
    public GameObject bt_petunjuk;
    public GameObject bt_tentang;
    public GameObject keluar;

    public AudioSource buttonsound;
    public AudioClip Click;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Start is called before the first frame update
    public void open()
    {
        if (PanelKuis.name == "PanelKuis")
        {
            Debug.Log("berhasil");
            PanelKuis.SetActive(true);
            bt_kuis.SetActive(false);
            bt_mulaiAR.SetActive(false);
            bt_petunjuk.SetActive(false);
            bt_tentang.SetActive(false);
            keluar.SetActive(false);
        }
    }

    public void close()
    {
        if (PanelKuis.name == "PanelKuis")
        {
            PanelKuis.SetActive(false);
            bt_kuis.SetActive(true);
            bt_mulaiAR.SetActive(true);
            bt_petunjuk.SetActive(true);
            bt_tentang.SetActive(true);
            keluar.SetActive(true);
        }
    }

    public void Clicksound()
    {
        buttonsound.PlayOneShot(Click);
    }
}
