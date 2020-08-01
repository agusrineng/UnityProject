﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll : MonoBehaviour
{

    public GameObject scrolbar;
    float scroll_pos = 0;
    float[] pos;
    int posisi = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void next() {
        if (posisi < pos.Length - 1) {
            posisi += 1;
            scroll_pos = pos[posisi];
        }
    }

    public void prev()
    {
        if (posisi > 0)
        {
            posisi -= 1;
            scroll_pos = pos[posisi];
        }
    }


    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i=0; i < pos.Length; i++){
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrolbar.GetComponent<Scrollbar>().value;
        }
        else {
            for (int i = 0; i < pos.Length; i++)
            {
                if(scroll_pos < pos [i] + (distance / 2) && scroll_pos > pos [i] - (distance / 2)){
                    scrolbar.GetComponent<Scrollbar> ().value = Mathf.Lerp (scrolbar.GetComponent<Scrollbar>().value, pos[i], 0.15f);
                    posisi = i;
                }
            }
        }
    }
}
