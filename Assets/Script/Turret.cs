using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject silahin_kafasi;
    public GameObject radar;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        GameObject[] tümradarlar;
        tümradarlar = GameObject.FindGameObjectsWithTag("radar");
        foreach (var item in tümradarlar)
        {
            item.SetActive(false);
         
        }
        radar.SetActive(true);
    }

    void Update()
    {
        silahin_kafasi.transform.Rotate(0, 1, 0);
    }
}
