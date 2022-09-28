using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform silahin_kafasi, namlu;
    // radarý sabitten deðil silahin içine ekledikten sonra sc ye ekle 
    public GameObject radar;
    public GameObject kursun;
    public ParticleSystem alev_effect;
    public GameObject canvas;
    public float kursun_damage;
    public float ates_etme_araliði,kursun_hiz;

    public int silahin_leveli;
    public int gelisim_maliyeti;
    public int yikim_geliri;
    


    bool ates = false;
    float gelecek_atesi_suresi=0;
    public List<Transform> hedef;
    public  Transform suanki_hedef;
    GameObject kamera;




    Button_Kontrol button_Kontrol;

    float radar_kapatma_sayac = 5;


    public void ilk_temas(Collider other)
    {
      
        hedef.Add(other.gameObject.transform);
        suanki_hedef = hedef[0];
        ates = true;
    }

    public void ilk_temassizlik(Collider other)
    {
        hedef.Remove(other.gameObject.transform);
        if (hedef.Count > 0 )
        {
            suanki_hedef = hedef[0];
        }
        else
        {
            suanki_hedef = null;
            ates = false;
            if (alev_effect != null)
            {
                alev_effect.Stop();
            }
        }
    }



    void Start()
    {
        kamera = GameObject.Find("Main Camera");
        kursun.GetComponent<kursun>().damage = kursun_damage;
        hedef = new List<Transform>();
        button_Kontrol = GameObject.Find("Game_Manager").GetComponent<Button_Kontrol>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        
    

        if (radar.GetComponent<MeshRenderer>().enabled == true)
        {

            radar.GetComponent<MeshRenderer>().enabled = false;
            GameObject[] tümradarlar;
            tümradarlar = GameObject.FindGameObjectsWithTag("radar");
            foreach (var item in tümradarlar)
            {

                item.GetComponent<MeshRenderer>().enabled = false;

            }
        }
        else
        {
            radar_kapatma_sayac = 5;
            GameObject[] tümradarlar;
            tümradarlar = GameObject.FindGameObjectsWithTag("radar");
            foreach (var item in tümradarlar)
            {

                item.GetComponent<MeshRenderer>().enabled = false;

            }
            radar.GetComponent<MeshRenderer>().enabled = true;
        }
    }


    public void tum_radar_kapat()
    {
        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {

            item.GetComponent<MeshRenderer>().enabled = false;

        }

       
    }

    void Update()
    {
        if (suanki_hedef != null)
        {
            silahin_kafasi.LookAt(suanki_hedef);
            
        }
        else
        {
        silahin_kafasi.Rotate(0, 1, 0);
        }
        if (ates == true)
        {            
            if (Time.time > gelecek_atesi_suresi)
            {
             
                ateset();
                gelecek_atesi_suresi = Time.time + ates_etme_araliði;
                if (alev_effect != null)
                {                 
                    alev_effect.Play();
                }
            }
        }

        if (radar.GetComponent<MeshRenderer>().enabled == true)
        {
            canvas.SetActive(true);
            if (radar_kapatma_sayac>0)
            {

            radar_kapatma_sayac -= Time.deltaTime;
            }
            else
            {
             tum_radar_kapat();
            }
        }
        else
        {
            canvas.SetActive(false);
        }

        canvas.transform.LookAt(kamera.transform);
    }

    public void ateset()
    {
       
        if (suanki_hedef == null && ates == true)
        {
            for (int i = 0; i < hedef.Count; i++)
            {
                if (hedef[i] == null)
                {
                    hedef.RemoveAt(i);
                }
            }

            if (hedef.Count > 0)
            {
                suanki_hedef = hedef[0];
            }
            else
            {
                ates = false;
                if (alev_effect != null)
                {
                   
                    alev_effect.Stop();
                }
            }

        }
        kursun_uret();
    }

    public void kursun_uret()
    {
        GameObject yeni_kursun = Instantiate(kursun, namlu.position, Quaternion.identity);
        yeni_kursun.transform.LookAt(suanki_hedef);
        yeni_kursun.GetComponent<Rigidbody>().velocity = namlu.forward * kursun_hiz;
        Destroy(yeni_kursun, 1f);
    }

}
