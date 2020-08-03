using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awalan : MonoBehaviour
{
    int random;
    int soal = 0;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(3, 12);
        transform.parent.GetChild(random).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
