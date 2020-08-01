using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationauto : MonoBehaviour
{
    float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
