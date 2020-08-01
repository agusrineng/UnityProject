using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popup : MonoBehaviour
{
    public GameObject PopUp;
    public bool aktif;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void OnMouseDown()
    {
        PopUp.SetActive(aktif);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
