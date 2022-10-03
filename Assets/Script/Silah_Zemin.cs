using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Silah_Zemin : MonoBehaviour
{



    Button_Kontrol button_kontrol;
    public GameObject button_canvas;
     Game_Manager game_manger;

    // Start is called before the first frame update11
    void Start()
    {
        button_kontrol = GameObject.Find("Game_Manager").GetComponent<Button_Kontrol>();
        game_manger = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
    }


    public void OnMouseDown()
    {
        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {

            item.GetComponent<MeshRenderer>().enabled = false;

        }

        if (button_canvas.activeSelf == true)
        {            
            button_kontrol.olusacak_silah_kordinat = gameObject.transform;
        }
        else
        {            
            button_canvas.SetActive(true);            
            button_kontrol.olusacak_silah_kordinat = gameObject.transform;
        }
    }



   
    // Update is called once per frame
    void Update()
    {
       

    }
}
