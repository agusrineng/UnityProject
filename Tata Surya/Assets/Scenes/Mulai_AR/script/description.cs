using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    public class description : MonoBehaviour
    {

        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;

        public AudioSource soundTarget;
        public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
            Application.targetFrameRate = 60;
            //add Audio Source as new game object component
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);


                //Apabila Object IPhone dimunculkan maka akan memunculkan deskripsi IPhone.

                if (name == "IPhone8")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/IPhone8"); });
                    TextDescription.GetComponent<Text>().text = "IPhone ialah …";
                }



                // Apabila Object Laptop Acer dimunculkan maka akan memunculkan deskripsi Laptop Acer.

                if (name == "LaptopAcer")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/LaptopAcer"); });
                    TextDescription.GetComponent<Text>().text = "Laptop Acer dibuat pada …";
                }
            }
        }

        //Fungsi Suara dimunculkan menggunakan button
        void playSound(string ss)
        {
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }
    }
}
