using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour
{
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
           // Debug.Log("düþmana çarptý");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
