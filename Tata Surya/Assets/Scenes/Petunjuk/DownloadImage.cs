using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Downloadmarker()
    {
        Application.OpenURL("https://drive.google.com/folderview?id=12RtbmKMQZ3Z6h-ZHAX44UZcDQVt0U0uF");
    }
}
