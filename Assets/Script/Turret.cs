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
    public List<Transform> hedef;
    public  Transform suanki_hedef;
    public float ates_etme_araliði,kursun_hiz;
    public float gelecek_atesi_suresi=0;
    bool ates = false;

    public int silahin_leveli;
    public int gelisim_maliyeti;
    public int yikim_geliri;

    Button_Kontrol button_Kontrol;



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
        hedef = new List<Transform>();
        button_Kontrol = GameObject.Find("Game_Manager").GetComponent<Button_Kontrol>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        
        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {
            
            item.GetComponent<MeshRenderer>().enabled = false;
            
        }
        radar.GetComponent<MeshRenderer>().enabled = true;
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
                    Debug.Log("d3eðil");
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
