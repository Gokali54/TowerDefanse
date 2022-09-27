using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radar_cember : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GetComponentInParent<Turret>().ilk_temas(other);
          
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag =="Enemy")
        {
           
            GetComponentInParent<Turret>().ilk_temassizlik(other);
        }
    }

  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, -1, 0);
    }
}
