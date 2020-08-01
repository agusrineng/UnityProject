using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupp : MonoBehaviour
{
    public GameObject PopUp;
    public bool aktif;

    // Start is called before the first frame update
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
