using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun : MonoBehaviour
{
    public float damage;

    Vector3 yon;

    public Time timescalee;
   public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 
    void Update()
    {


        if (enemy == null)
        {
            Destroy(gameObject);
        }
        else
        {
         gameObject.transform.LookAt(enemy);    
        transform.position = Vector3.Lerp(transform.position, enemy.position, 1f);
          
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
