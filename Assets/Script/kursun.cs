using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("d��mana �arpt�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
