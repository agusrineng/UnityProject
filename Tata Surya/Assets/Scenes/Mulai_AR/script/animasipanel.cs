using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class animasipanel : MonoBehaviour
{
    public GameObject PanelDescription;
    public GameObject PanelDescription2;
    public GameObject buttondata;
    public GameObject buttondeskrip1;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void open()
    {
        if (PanelDescription.name == "PanelDescription")
        {
            Debug.Log("berhasil");
            PanelDescription.SetActive(true);
            buttondeskrip1.gameObject.SetActive(false);
        }
    }

    public void open2()
    {
        if (PanelDescription2.name == "PanelDescription2")
        {
            Debug.Log("berhasil");
            PanelDescription2.SetActive(true);
            buttondata.gameObject.SetActive(false);
        }
    }
}
