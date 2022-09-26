using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Silah_Zemin : MonoBehaviour
{



    Button_Kontrol button_kontrol;
    public GameObject button_canvas;

    // Start is called before the first frame update11
    void Start()
    {
        button_kontrol = GameObject.Find("Game_Manager").GetComponent<Button_Kontrol>();
    }


    public void OnMouseDown()
    {
        Debug.Log("Silah_zemin");
      
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
