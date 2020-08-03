using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingtew : MonoBehaviour
{
    int random;
    public int soal = 0;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(3, 12);
        transform.parent.GetChild(random).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(soal);
    }
}
