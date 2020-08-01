using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muncul : MonoBehaviour
{
    float time = 1;
    public GameObject[] allObject;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 100;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < allObject.Length; i++)
        {
            obj(allObject[i].name, allObject[i]);
        }

    }
    void obj(string nama, GameObject go)
    {
        if (go.name == nama)
        {
            if (go.GetComponent<SphereCollider>().enabled)
            {
                go.SetActive(true);
                if (time > 0)
                {
                    Debug.Log("waktu" + time);
                    time -= Time.deltaTime;
                }
                else
                {
                    go.GetComponent<Animator>().enabled = false;
                }
            }
            if (!go.GetComponent<SphereCollider>().enabled && !go.GetComponent<Animator>().enabled)
            {
                time = 1;
                go.SetActive(false);
                go.GetComponent<Animator>().enabled = true;
            }
        }
    }
}
