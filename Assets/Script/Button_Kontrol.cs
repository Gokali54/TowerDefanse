using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Kontrol : MonoBehaviour
{
    public GameObject silah_Zemin;
    public GameObject turret_1, turret_2, turret_3;
    public GameObject islem_yapilacak_silah;
    public Transform olusacak_silah_kordinat;
    public GameObject btn_canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void turret_1_add()
    {
        GameObject yeni_turret = Instantiate(turret_1, olusacak_silah_kordinat.position, Quaternion.identity);
        olusacak_silah_kordinat = null;
        btn_canvas.SetActive(false);

        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {
            Debug.Log(tümradarlar.Length);
            //item.GetComponent<MeshRenderer>().enabled = false;
            item.SetActive(false);
        }


    }



    public void turret_2_add()
    {
        GameObject yeni_turret = Instantiate(turret_2, olusacak_silah_kordinat.position, Quaternion.identity);
        olusacak_silah_kordinat = null;
        btn_canvas.SetActive(false);
        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {
            //item.GetComponent<MeshRenderer>().enabled = false;
        }

    }

    public void turret_3_add()
    {
        GameObject yeni_turret = Instantiate(turret_3, olusacak_silah_kordinat.position, Quaternion.identity);
        olusacak_silah_kordinat = null;
        btn_canvas.SetActive(false);
        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {
          //  item.GetComponent<MeshRenderer>().enabled = false;

        }

    }


    public void close()
    {
        btn_canvas.SetActive(false);
    }
    // Update is called once per frame

    public void OnMouseDown()
    {
        Debug.Log("bton kontrol");
    }

    void Update()
    {

       
    }
}
