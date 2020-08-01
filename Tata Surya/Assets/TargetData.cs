using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Vuforia
{
    public class TargetData : MonoBehaviour
    {
        public Transform TextTargetNama;
        public Transform TextDescripsi;
        public Transform ButtonAksi;
        public Transform PanelDescropsi;

        public AudioSource suaraTarget;
        public AudioClip klipTarget;

        // Use this for initialization
        void Start()
        {
            //add Audio Source as new game object component
            suaraTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
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

                TextTargetNama.GetComponent<Text>().text = name;
                ButtonAksi.gameObject.SetActive(true);
                TextDescripsi.gameObject.SetActive(true);
                PanelDescropsi.gameObject.SetActive(true);


                //If the target name was “zombie” then add listener to ButtonAction with location of the zombie sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie
                if (name == "Bumi")
                {
                    TextDescripsi.GetComponent<Text>().text = "KERAK"+Environment.NewLine+"(Batuan silikat padat sebagian besar basal)"+Environment.NewLine+""+Environment.NewLine+"MANTEL"+Environment.NewLine+"(Batuan silikat padat)"+Environment.NewLine+""+Environment.NewLine+"INTI LUAR"+Environment.NewLine+"(Besi cair dan nikel)"+Environment.NewLine+""+Environment.NewLine+"INTI DALAM"+Environment.NewLine+"(Besi Padat dan nikel)";
                }

                if (name == "Venus")
                {
                    TextDescripsi.GetComponent<Text>().text = "KERAK"+Environment.NewLine+"(Batuan Silikat padat sebagian besar basal)"+Environment.NewLine+""+Environment.NewLine+"MANTEL"+Environment.NewLine+"(Batuan silikat padat)"+Environment.NewLine+""+Environment.NewLine+"INTI LUAR"+Environment.NewLine+"(Besi cair dan nikel)"+Environment.NewLine+""+Environment.NewLine+"INTI DALAM"+Environment.NewLine+"(Besi padat dan nikel)";
                }

                if (name == "Mars")
                {
                    TextDescripsi.GetComponent<Text>().text = "KERAK" + Environment.NewLine + "(Batuan basaltik kaya besi)" + Environment.NewLine + "" + Environment.NewLine + "MANTEL" + Environment.NewLine + "(Batuan silikat padat)" + Environment.NewLine + ""+ Environment.NewLine + "INTI DALAM" + Environment.NewLine + "(Sebagian besar cair, nikel dan belerang)";
                }

                if (name == "Jupiter")
                {
                    TextDescripsi.GetComponent<Text>().text = "ATMOSFER" + Environment.NewLine + "(Molekul hidrogen dan helium)" + Environment.NewLine + "" + Environment.NewLine + "MANTEL" + Environment.NewLine + "(Logam cair hidrogen dan helium)" + Environment.NewLine + ""+ Environment.NewLine + "INTI" + Environment.NewLine + "(Besi Padat yang padat)";
                }

                if (name == "Saturnus")
                {
                    TextDescripsi.GetComponent<Text>().text = "ATMOSFER" + Environment.NewLine + "(Molekul hidrogen dan helium)" + Environment.NewLine + "" + Environment.NewLine + "MANTEL" + Environment.NewLine + "(Logam cair hidrogen dan helium)" + Environment.NewLine + "" + Environment.NewLine + "INTI" + Environment.NewLine + "(Batuan Padat yang padat)";
                }

                if (name == "Uranus")
                {
                    TextDescripsi.GetComponent<Text>().text = "ATMOSFER" + Environment.NewLine + "(Gas hidrogen, helium dan metana)" + Environment.NewLine + "" + Environment.NewLine + "MANTEL" + Environment.NewLine + "(Es air, amonia, metana)" + Environment.NewLine + "" + Environment.NewLine + "INTI" + Environment.NewLine + "(Silikat/Besi-nikel batu)";
                }

                if (name == "Neptunus")
                {
                    TextDescripsi.GetComponent<Text>().text = "ATMOSFER" + Environment.NewLine + "(Gas hidrogen, helium dan metana)" + Environment.NewLine + "" + Environment.NewLine + "MANTEL" + Environment.NewLine + "(Es air, amonia, metana)" + Environment.NewLine + "" + Environment.NewLine + "INTI" + Environment.NewLine + "(Silikat/Besi-nikel batu)";
                }

                if (name == "Merkurius")
                {
                    TextDescripsi.GetComponent<Text>().text = "Kerak"+ Environment.NewLine +"(Permukaan Batu Silikat)"+ Environment.NewLine +""+Environment.NewLine+"Mantel"+Environment.NewLine+"(Batu Silikat Padat)"+Environment.NewLine+""+Environment.NewLine+"Inti"+Environment.NewLine+"(Besi Cair)"+Environment.NewLine+""+Environment.NewLine+""+Environment.NewLine+"STRUKTUR"+Environment.NewLine+"    Keraknya memiliki penampilan yang mirip dengan Bulan. Ciri khas kerak permukaan adalah adanya banyak punggungan sempit, yang mungkin terbentuk ketika inti dan mantel Merkurius didinginkan dan dikontrak setelah kerak mengeras."+Environment.NewLine+"INTI"+Environment.NewLine+"    Kepadatan ekstrim Merkurius menyimpulkan bahwa planet ini memiliki inti besar yang kaya akan zat besi, dengan kandungan besi lebih tinggi dari planet utama lainnya di Tata Surya.";
                }
            }
        }
    }
}
