using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Vuforia
{
    public class DataTarget : MonoBehaviour
    {
        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;
        public Transform TextDescription2;
        public Transform PanelDescription2;
        public Transform buttondeskrip1;
        public Transform buttondata;

        public GameObject Panel;
        public GameObject Panel2;

        public AudioSource soundTarget;
        public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
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
                TextDescription2.gameObject.SetActive(true);
                //PanelDescription2.gameObject.SetActive(true);
                buttondeskrip1.gameObject.SetActive(true);
                buttondata.gameObject.SetActive(true);


                //If the target name was “zombie” then add listener to ButtonAction with location of the zombie sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie
                if (Panel.active == true)
                {
                    buttondeskrip1.gameObject.SetActive(false);
                }

                if (Panel2.active == true)
                {
                    buttondata.gameObject.SetActive(false);
                }

                if (name == "Uranus")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/uranus"); });
                    TextDescription.GetComponent<Text>().text = "     Uranus merupakan planet pertama yang ditemukan dengan bantuan teleskop. Planet ini ditemukan oleh William Herschel pada 13 Maret 1781. Pada tahun 1977 ditemukan cincin yang mengitari Uranus. Cincin Uranus berbeda dengan cincin Saturnus. Cincin Uranus tidak terlihat jelas seperti cincin Saturnus. Cincin Uranus sangat tipis dan gelap." + Environment.NewLine + "" + Environment.NewLine + "     Atmosfer Uranus terdiri atas hidrogen, helium, metana dan amonia. Jarak Uranus ke Matahari cukup jauh. Oleh karena itu, hanya sedikit cahaya dan panas Matahari yang sampai ke Uranus. Hal ini mengakibatkan suhu Uranus sangat dingin, yaitu sekitar -180°C." + Environment.NewLine + "" + Environment.NewLine + "     Ciri Uranus lainnya adalah cara berputarnya. Poros Uranus memiliki kemiringan ke kanan sebesar 98° sehingga Uranus tampak bergerak seperti sebuah gasing yang mengelilingi." + Environment.NewLine + "" + Environment.NewLine + "     Uranus memiliki 27 satelit, antara lain Titania, Ariel, Miranda, Oberan dan Umbriel. Titania merupakan satelit terbesar Uranus.";
                    TextDescription2.GetComponent<Text>().text = "Data Uranus" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 50.800 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 2.900 juta km" + Environment.NewLine + "Kala rotasi : 24 jam" + Environment.NewLine + "Kala revolusi : 84,1 tahun" + Environment.NewLine + "Suhu permukaan : -180°C" + Environment.NewLine + "Jumlah satelit : 27";
                }

                if (name == "Tata_Surya")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/tatasurya"); });
                    TextDescription.GetComponent<Text>().text = "A Tata Surya bla bla.";
                    PanelDescription2.gameObject.SetActive(false);
                    buttondata.gameObject.SetActive(false);
                }

                if (name == "Mars")
                {
                    TextDescription.GetComponent<Text>().text = "     Mars merupakan planet yang terletak pada urutan keempat dari Matahari. Sebagian permukaan Mars berupa gurun luas yang terdiri atas tanah dan batuan kecil-kecil berwarna merah sehingga Mars dikenal sebagai planet merah." + Environment.NewLine + "" + Environment.NewLine + "     Atmosfer di Mars lebih tipis jika dibandingkan dengan atmosfer Bumi. Hal ini terjadi karena Mars memiliki gaya gravitasi yang lebih kecil dan gas  yang lebih ringan telah keluar dari atmosfernya. Atmosfer Mars terdiri atas 96% karbon dioksida, 2,7% nitrogen, 1,6% argon, dan 0,2% oksigen."+ Environment.NewLine +""+ Environment.NewLine +"     Pada tahun 1971, Amerika Serikat meluncurkan pesawat penjelajah Mariner 9. Berdasarkan foto yang diambil, tampak lembah berkelok di Mars yang diduga merupakan sungai yang mengering. Selain itu, juga terdapat gunung-gunung api di Mars. Pada tahun 1976, Amerika Serikat meluncurkan pesawat Viking I dan II. Berdasarkan foto yang diambil diketahui bahwa permukaan Mars sangat gersang dan berbatu-batu."+ Environment.NewLine +""+ Environment.NewLine +"     Mars memiliki dua satelit, yaitu Phobos dan Deimos. Kedua satelit ini ditemukan oleh astronom Amerika Serikat yang bernama Asaph Hall pada tahun 1877.";
                    TextDescription2.GetComponent<Text>().text = "Data Mars" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 6.974 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 227 juta km" + Environment.NewLine + "Kala rotasi : 1,026 hari (24,6 jam)" + Environment.NewLine + "Data revolusi : 686,96 hari" + Environment.NewLine + "Suhu permukaan : (-115)°C - 24°C" + Environment.NewLine + "Jumlah satelit : 2";
                }

                if (name == "Venus")
                {
                    TextDescription.GetComponent<Text>().text = "     Venus tampak seolah memancarkan cahaya yang sangat cemerlang. Oleh karena itu, Venus disebut bintang kejora. Venus kadang-kadang tampak disebelah timur sebelum Matahari terbit sehingga planet ini disebut juga bintang fajar atau bintang timur. Setelah Matahari terbenam, kita juga dapat melihat venus disebelah barat sehingga disebut bintang senja atau bintang barat. Jadi, ada banyak sebutan untuk planet ini." + Environment.NewLine + "" + Environment.NewLine + "     Diameter dan massa Venus hampir sama dengan Bumi. Venus berdiameter 12.102 km, sedangkan Bumi lebih kurang 12.756,3 km. Apabila kita perhatikan kala rotasi kedua planet, maka terdapat perbedaan waktu yang mencolok. Kala rotasi bumi hanya 1 hari, sedangkan kala rotasi venus  243 hari. Dapat kita katakan bahwa Venus berotasi sangat lambat. Namun, Venus lebih cepat beredar mengelilingi Matahari daripada Bumi. Kala revolusi Venus 225 hari, sedangkan Bumi 365 hari." + Environment.NewLine + "" + Environment.NewLine + "     Venus memiliki atmosfer yang selalu berawan sehingga sulit untuk mengetahui sifat permukaannya. Atmosfer Venus tersusun dari 96% karbon dioksida, 3,4% nitrogen, kurang dari 0,1% uap air dan sisanya berupa gas lain. Suhu permukaan Venus berkisar antara 450°C sampai 480°C suhu yang sangat panas ini menyebabkan tidak ada kehidupan di planet ini. Venus tidak memiliki satelit." + Environment.NewLine + "" + Environment.NewLine + "     Pesawat ruang angkasa Amerika Serikat, Mariner 2, berhasil terbang mendekati Venus pada tahun 1962. Tahun 1975, pesawat ruang angkasa milik Uni Soviet (sekarang Rusia) bernama venera 9 dan 10 juga berhasil mendekati planet Venus." + Environment.NewLine + "" + Environment.NewLine + "     Pada tahun 1978, Amerika Serikat meluncurkan pesawat pengorbit Pioneer untuk membuat peta permukaan Venus. Pada tahun 1989, Amerika Serikat kembali meluncurkan pesawat Magellan mengitari Venus.";
                    TextDescription2.GetComponent<Text>().text = "Data Venus" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 12.102 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 108 juta km" + Environment.NewLine + "Kala rotasi : 243 hari" + Environment.NewLine + "Kala revolusi : 225 hari" + Environment.NewLine + "Suhu permukaan : 450°C - 480°C" + Environment.NewLine + "Jumlah satelit : 0";
                }

                if (name == "Merkurius")
                {
                    TextDescription.GetComponent<Text>().text = "     Merkurius merupakan planet terdekat dengan Matahari dan memiliki kala revolusi tercepat dalam tata surya. Orbit Merkurius berbentuk elips sehingga jarak Merkurius ke Matahari berubah-ubah. Jarak terdekat kira-kira 47 juta km, sedangkan jarak terjauh sekitar 69 juta km. suhu permukaan Merkurius juga bervariasi. Suhu ketika menghadap ke Matahari (siang) dapat mencapai 400°C, sedangkan saat membelakangi Matahari (malam) mencapai -170°C." + Environment.NewLine + "" + Environment.NewLine + "     Pada tahun 1974, pesawat ruang angkasa Amerika Serikat, Mariner 10, berhasil mendekati Merkurius. Berdasarkan foto-foto yang diambil, terlihat permukaan Merkurius penuh dengan kawah, berbatu-batu dan berdebu seperti permukaan bulan. Kawah Merkurius terbentuk akibat kejatuhan meteorit besar." + Environment.NewLine + "" + Environment.NewLine + "    Di angkasa, Merkurius kadang-kadang tampak bersinar bagaikan bintang yang paling terang. Merkurius terlihat paling jelas pada waktu senja atau menjelang pagi jika dilihat dari bumi.";
                    TextDescription2.GetComponent<Text>().text = "Data Merkurius" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 4.878 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 58 juta km" + Environment.NewLine + "Kala rotasi : 58,65 hari" + Environment.NewLine + "Kala revolusi : 88 hari" + Environment.NewLine + "Suhu permukaan : (-170)°C - 400°C" + Environment.NewLine + "Jumlah satelit : 0";
                }

                if (name == "Jupiter")
                {
                    TextDescription.GetComponent<Text>().text = "     Yupiter merupakan planet terbesar dalam Tata Surya kita. Diameter Yupiter lebih kurang 11 kali diameter Bumi. Permukaan Yupiter diselimuti oleh awan tebal yang sebagian besar terdiri atas gas hidrogen dan helium. Yupiter tampak bersinar terang dilangit pada malam hari meskipun jaraknya sangat jauh dari Bumi. Hal demikian dimungkinkan karena Yupiter berukuran besar dan awan tebal yang menyelimutinya mampu memantulkan sinar Matahari dengan kuat."+ Environment.NewLine+""+"     Yupiter memiliki tanda berbentuk lonjong besar yang disebut noda merah besar. Panjangnya kira-kira 48.270 km dan lebarnya 16.090 km. Noda tersebut dapat dilihat pada waktu tertentu saja. Beberapa ilmuwan yang pernah melihat noda tersebut, antara lain Robert Hooke (1660), Gian Domenico Cassani (1660) dan Edward Barnard (1878)."+ Environment.NewLine +""+Environment.NewLine+"     Yupiter memiliki 67 satelit. Ganymede merupakan satelit terbesar yang dimiliki Yupiter. Satelit lainnya yang cukup besar, yaitu lo, Europa dan Callisto."+Environment.NewLine+""+Environment.NewLine+"     Pada tahun 1973, Amerika Serikat mengirimkan pesawat Pioneer 10 melintasi Yupiter dan mengambil foto. Tahun berikutnya, Amerika Serikat mengirimkan lagi pesawat Pioneer 11, Voyager 1 dan Voyager 2 untuk meneliti Yupiter dan satelitnya. Pada tahun 1989, Amerika Serikat kembali mengirim pesawatnya, Galileo untuk mengamati planet tersebut.";
                    TextDescription2.GetComponent<Text>().text = "Data Yupiter" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 142.796 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 778 juta km" + Environment.NewLine + "Kala rotasi : 9 jam 50 menit" + Environment.NewLine + "Kala revolusi : 11,86 tahun" + Environment.NewLine + "Suhu permukaan : -140°C" + Environment.NewLine + "Jumlah satelit : 67";
                }

                if (name == "Saturnus")
                {
                    TextDescription.GetComponent<Text>().text = "     Saturnus merupakan planet terbesar kedua setelah Yupiter. Ciri yang paling istimewa dari Saturnus adalah adanya tujuh lingkaran cincin yang mengelilingi planet tersebut. Lingkaran cincin tersusun dari pecahan-pecahan batu berlapis es. Tebal cincin tersebut hanya 30 km, tetapi lebar keseluruhan cincin lebih dari 272.000 km."+Environment.NewLine+""+Environment.NewLine+"     Penampilan cincin Saturnus berubah-ubah, bergantung pada waktu pengamatan. Sudut cincin saturnus tampak berubah menurut letak Saturnus dan Bumi pada masing-masing orbitnya."+Environment.NewLine+""+Environment.NewLine+"     Atmosfer Saturnus sebagian besar berupa hidrogen. Gas lain berupa helium, metana dan kristal amonia. Pesawat ruang angkasa yang berhasil mendekati Saturnus, antara lain Voyager 1 dan 2, serta Pioneer II."+Environment.NewLine+""+Environment.NewLine+"     Saturnus memiliki 62 satelit. Semua satelit terbentuk dari es, kecuali satelit terbesarnya, Titan. ";
                    TextDescription2.GetComponent<Text>().text = "Data Saturnus" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 120.660 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 1.400 juta km" + Environment.NewLine + "Kala rotasi : 10 jam 14 menit" + Environment.NewLine + "Kala revolusi : 29,46 tahun" + Environment.NewLine + "Suhu permukaan : -160°C" + Environment.NewLine + "Jumlah satelit : 62";
                }

                if (name == "Matahari")
                {
                    TextDescription.GetComponent<Text>().text = "Matahari adalah benda langit berupa bola gas panas besar berpijar. Bola gas panas tersebut terdiri atas gas hydrogen (70%), gas helium (25%), dan gas lain seperti oksigen, karbon, nitrogen dan belerang (5%). Matahari merupakan anggota terbesar dalam tata surya dan menjadi pusat Tata Surya. Diameter ekuator mencapai 864.000 mil atau sekitar 112 kali diameter ekuator bumi. Matahari dikenal sebagai sumber energi utama dalam kehidupan. Disebut demikian karena panas dan cahaya yang berasal dari matahari memungkinkan adanya kehidupan di bumi.";
                }

                if (name == "Bulan")
                {
                    TextDescription.GetComponent<Text>().text = "A Bulan bla bla.";
                }

                if (name == "Neptunus")
                {
                    TextDescription.GetComponent<Text>().text = "     Pada tanggal 23 September 1846, para ilmuwan berhasil menemukan planet Neptunus. Neptunus tampak berwarna biru kehijau-hijauan. Atmosfernya terdiri atas metana, hidrogen, amonia dan helium." + Environment.NewLine + "" + Environment.NewLine + "     Neptunus merupakan planet terjauh dari Matahari, yaitu berjarak sekitar 4.500 juta km. Planet ini sangat sedikit memperoleh cahaya dan panas Matahari. Oleh sebab itu, suhu di planet Neptunus, yaitu sekitar -200°C. Permukaan Neptunus tertutup lapisan es yang cukup tebal." + Environment.NewLine + "" + Environment.NewLine + "     Neptunus memiliki 14 satelit. Triton, Nereid dan Proteus merupakan tiga satelit berukuran besar.";
                    TextDescription2.GetComponent<Text>().text = "Data Neptunus" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 48.600 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 4.500 juta km" + Environment.NewLine + "Kala rotasi : 22 jam" + Environment.NewLine + "Kala revolusi : 164,8 tahun" + Environment.NewLine + "Suhu permukaan : -200°C" + Environment.NewLine + "Jumlah satelit : 14";
                }

                if (name == "Asteroid")
                {
                    TextDescription.GetComponent<Text>().text = "     Asteroid merupakan gugusan benda langit berukuran lebih kecil dari planet yang mengelilingi Matahari pada lintasan tertentu. Asteroid sering juga disebut planet kecil atau planet minor atau planetoid. Asteroid diduga berasal dari sisa-sisa bahan planet yang gagal membentuk planet."+Environment.NewLine+""+Environment.NewLine+"     Sebagian besar lintasan asteroid terletak di antara planet Mars dan Yupiter, membentuk daerah yang disebut sabuk asteroid. Beberapa asteroid ada yang terlempar keluar orbit asteroid sehingga tidak berada di sabuk asteroid lagi. Hal ini disebabkan adanya pengaruh gravitasi Yupiter yang besar."+Environment.NewLine+"     Asteroid yang pertama kali ditemukan adalah Ceres. Ceres ditemukan pada tanggal 1 Januari 1801 oleh astronom Italia, Guiseppe Piazzi. Ceres merupakan asteroid terbesar dengan diameter sekitar 933 km. Setelah Ceres, ditemukan juga beberapa asteroid lain seperti Hidalgo, Hermes, Vesta, Pallas dan Ida.";
                    PanelDescription2.gameObject.SetActive(false);
                    buttondata.gameObject.SetActive(false);
                }

                if (name == "Satelit")
                {
                    TextDescription.GetComponent<Text>().text = "     Benda kecil diangkasa yang berputar mengelilingi benda lain yang berukuran lebih besar disebut satelit. Ada dua macam satelit, yaitu satelit alam dan satelit buatan."+Environment.NewLine+""+Environment.NewLine+"a. Satelit Alam"+Environment.NewLine+"     Satelit alam merupakan benda langit yang mengelilingi sebuah planet. Contoh satelit alam adalah bulan."+Environment.NewLine+"     Apabila dilihat dari Bumi, Bulan tampak bercahaya seperti Matahari. Bulan tampak bercahaya karena Bulan memantulkan cahaya Matahari. Bulan tidak memiliki cahaya sendiri seperti halnya Matahari."+Environment.NewLine+""+Environment.NewLine+"b. Satelit Buatan"+Environment.NewLine+"     Satelit buatan merupakan satelit yang sengaja dibuat dan ditempatkan dalam orbit untuk keperluan tertentu. Satelit buatan pertama, yaitu Sputnik I yang diluncurkan Uni Soviet pada 4 Oktober 1957."+Environment.NewLine+""+Environment.NewLine+"     Indonesia memiliki beberapa satelit buatan, antara lain Palapa B-2, Palapa B-2P dan Palapa C. Satelit Palapa digunakan sebagai sarana komunikasi."+Environment.NewLine+""+Environment.NewLine+"     Selain sebagai sarana komunikasi, satelit buatan digunakan juga untuk:"+Environment.NewLine+"1).  Mengamati perubahan cuaca"+Environment.NewLine+"2).  Pengintaian"+Environment.NewLine+"3).  Penyelidikan ruang angkasa"+Environment.NewLine+"4).  Bantuan navigasi"+Environment.NewLine+"5).  Laboratorium di ruang angkasa"+Environment.NewLine+"6).  Menuntun roket militer agar dapat mengenai sasaran";
                    PanelDescription2.gameObject.SetActive(false);
                    buttondata.gameObject.SetActive(false);
                }

                if (name == "Pluto")
                {
                    TextDescription.GetComponent<Text>().text = "     Pluto pertama kali ditemukan oleh Clyde W. Tombaugh, yaitu pada tanggal 18 Februari 1930. Pada saat itu Pluto dianggap sebagai satu-satunya planet yang berada di ruang angkasa setelah Neptunus."+ Environment.NewLine+""+Environment.NewLine+"     Selama bertahun-tahun Pluto telah dianggap sebagai planet kesembilan dalam Tata Surya kita. Namun, sejak ditemukan ribuan objek kecil yang berada setelah Neptunus, yang kemudian dinamakan objek sabuk Kuiper (Kuiper Belt Object) keberadaan Pluto sebagai sebuah planet mulai diragukan. Hal ini disebabkan kemiripan Pluto dengan objek sabuk Kuiper. Objek sabuk Kuiper berukuran kecil, beku (berbalut es) dan bergerak lambat mengelilingi Matahari. Hal demikian mirip dengan ciri Pluto yang memiliki ukuran kecil, suhu permukaannya mencapai -238°C, serta memiliki orbit yang sangat lonjong dan dalam periode tertentu orbit Pluto tersebut dapat memotong orbit Neptunus."+Environment.NewLine+""+Environment.NewLine+"     Pada tanggal 14-25 Agustus 2006, lebih kurang 2.500 astronom dari 75 negara yang tergabung dalam International Astronomical Union (IAU) mengadakan pertemuan di Praha, Ceko, untuk membicarakan jumlah planet sebenarnya dalam Tata Surya. Dalam sidang umum IAU tersebut astronom sepakat bahwa benda langit dapat disebut sebagai planet jika memenuhi ketetuan sebagai berikut."+Environment.NewLine+"a. Planet adalah benda angkasa yang berorbit mengelilingi bintang (matahari)."+Environment.NewLine+"b. Planet memiliki ukuran cukup besar."+Environment.NewLine+"c. Planet memiliki garis edar yang tidak bersinggungan dengan orbit planet lain."+Environment.NewLine+""+Environment.NewLine+"     Berdasarkan kriteria planet, Pluto tidak memenuhi syarat untuk dianggap sebagai planet. Dalam hal ini, Pluto memiliki ukuran kecil, bahkan lebih kecil dari Bulan. Orbit Pluto berbentuk elips tumpang tindih atau bersinggungan dengan orbit Neptunus. Akhirnya, pada tanggal 24 Agustus 2006 Pluto yang selama 75 tahun dianggap sebagai Planet kesembilan, resmi dikeluarkan dari daftar planet dalam Tata Surya kita. Selanjutnya Pluto hanya dikategorikan sebagai planet kerdil.";
                    TextDescription2.GetComponent<Text>().text = "Data Pluto" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 2.320 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 6.000 juta km" + Environment.NewLine + "Kala rotasi : 6,38 hari" + Environment.NewLine + "Kala revolusi : 248,5 tahun" + Environment.NewLine + "Suhu permukaan : -238°C";
                }


                if (name == "Bumi")
                {
                    ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/bumi"); });
                    TextDescription.GetComponent<Text>().text = "     Bumi merupakan satu-satunya planet yang memiliki atmosfer dan suhu yang memungkinkan adanya kehidupan. Permukaan Bumi diselimuti oleh atmosfer yang terdiri atas gas nitrogen (78%), oksigen (21%), serta argon, hidrogen, karbon dioksida dan helium (1%). Kira-kira 71% dari luas permukaan Bumi merupakan lautan, sedangkan sisanya berupa daratan."+Environment.NewLine+""+Environment.NewLine+"     Atmosfer bumi memiliki arti penting bagi kehidupan manusia dan makhluk hidup lainnya. Atmosfer berfungsi melindungi Bumi dari bahaya sinar ultraviolet dan tabrakan benda-benda langit. Dengan adanya atmosfer, benda-benda langit yang menuju Bumi akan hancur (terbakar) saat memasuki atmosfer."+Environment.NewLine+""+Environment.NewLine+"     Bumi memiliki gaya tarik yang dikenal sebagai gaya gravitasi Bumi. Adanya gaya tarik tersebut menyebabkan seluruh benda yang ada di permukaan Bumi (termasuk kita) tidak terlempar ke ruang angkasa. Planet Bumi memiliki satu satelit, yaitu Bulan. Bulan mengelilingi Bumi dan bersama Bumi mengelilingi Matahari.";
                    TextDescription2.GetComponent<Text>().text = "Data Bumi" + Environment.NewLine + "" + Environment.NewLine + "Diameter ekuator : 12.756,3 km" + Environment.NewLine + "Jarak rata-rata ke Matahari : 150 juta km" + Environment.NewLine + "Kala rotasi : 1 hari" + Environment.NewLine + "Kala revolusi : 365,25 hari" + Environment.NewLine + "Suhu permukaan : (-88)°C - 57,8°C" + Environment.NewLine + "Jumlah satelit : 1";
                }
            }
        }
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
