using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject silahin_kafasi;
    // radar� sabitten de�il silahin i�ine ekledikten sonra sc ye ekle 
    public GameObject radar;
    public GameObject namlu, kursun;
   public List<Transform> hedef;
  public  Transform suanki_hedef;
    public Transform radar_transfor;

    public int silahin_leveli;
    public float ates_etme_arali�i;
    float gelecek_atesi_suresi;
    bool ates = false;
    public int gelisim_maliyeti;
    public int yikim_geliri;

    Button_Kontrol button_Kontrol;



    // gokhan de�i�iklik yapt�

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
        GameObject[] t�mradarlar;
        t�mradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in t�mradarlar)
        {
            item.GetComponent<MeshRenderer>().enabled = false;
         
        }
        radar.GetComponent<MeshRenderer>().enabled = true;
    }

    void Update()
    {
        silahin_kafasi.transform.Rotate(0, 1, 0);
    }
}
