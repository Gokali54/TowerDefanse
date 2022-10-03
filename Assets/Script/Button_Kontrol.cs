using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Kontrol : MonoBehaviour
{

    public GameObject silah_Zemin;
    public GameObject turret_1, turret_2, turret_3;
    public int turret_1_para, turret_2_para, turret_3_para;
    public GameObject islem_yapilacak_silah;
    public Transform olusacak_silah_kordinat;
    public GameObject btn_canvas;
    Game_Manager game_Manager;

    // Start is called before the first frame update
    void Start()
    {
        game_Manager = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
    }


    public void turret_1_add()
    {
        if (game_Manager.suanki_para > turret_1_para)
        {

       
        game_Manager.para_azalt(turret_1_para);
        GameObject yeni_turret = Instantiate(turret_1, olusacak_silah_kordinat.position, Quaternion.identity);
        olusacak_silah_kordinat = null;
        btn_canvas.SetActive(false);

        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {
           
            item.GetComponent<MeshRenderer>().enabled = false;
            
        }
        }


    }



    public void turret_2_add()
    {
        if (game_Manager.suanki_para > turret_2_para)
        {
            game_Manager.para_azalt(turret_2_para);

            GameObject yeni_turret = Instantiate(turret_2, olusacak_silah_kordinat.position, Quaternion.identity);
            olusacak_silah_kordinat = null;
            btn_canvas.SetActive(false);
            GameObject[] tümradarlar;
            tümradarlar = GameObject.FindGameObjectsWithTag("radar");
            foreach (var item in tümradarlar)
            {
                item.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }

    public void turret_3_add()
    {
        if (game_Manager.suanki_para > turret_3_para)
        {
            game_Manager.para_azalt(turret_3_para);

            GameObject yeni_turret = Instantiate(turret_3, olusacak_silah_kordinat.position, Quaternion.identity);
            olusacak_silah_kordinat = null;
            btn_canvas.SetActive(false);
            GameObject[] tümradarlar;
            tümradarlar = GameObject.FindGameObjectsWithTag("radar");
            foreach (var item in tümradarlar)
            {
                item.GetComponent<MeshRenderer>().enabled = false;

            }
        }
    }


    public void close()
    {
        btn_canvas.SetActive(false);
    }
    // Update is called once per frame

    public void OnMouseDown()
    {
      
    }

    void Update()
    {

       
    }
}
