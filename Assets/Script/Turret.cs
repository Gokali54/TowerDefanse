using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject silahin_kafasi;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        silahin_kafasi.transform.Rotate(0, 1, 0);
    }
}
