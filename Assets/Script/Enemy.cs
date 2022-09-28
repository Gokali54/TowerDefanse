using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Enemy : MonoBehaviour
{

    public float hiz;
    public float can;
    float simdiki_can;

    Game_Manager game_manager;
    GameObject kamera;
    GameObject takip_edilen_kup;
    public Image can_bar;
    public GameObject canvas;
    public int takip_edilen_kup_no;

    int gidecegi_yol;

    // Start is called before the first frame update

    private void Awake()
    {
        game_manager = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
        simdiki_can = can;
        if (gameObject.name == game_manager.Enemy_1.name + "(Clone)")
        {
            takip_edilen_kup_no = game_manager.Enemy_1_yol;
            gidecegi_yol = game_manager.Enemy_1_yol;
         
            if (gidecegi_yol != 1)
            {
                gidecegi_yol = 2;
            }
        }
        if (gameObject.name == game_manager.Enemy_2.name + "(Clone)")
        {
            takip_edilen_kup_no = game_manager.Enemy_2_yol;
            gidecegi_yol = game_manager.Enemy_2_yol;
            if (gidecegi_yol != 1)
            {
                gidecegi_yol = 2;
            }
        }
        kamera = GameObject.Find("Main Camera");
      
    }

    void can_azalt(float gelen_hasar)
    {
        simdiki_can = simdiki_can - gelen_hasar;
        can_bar.fillAmount = Mathf.Lerp(can_bar.fillAmount, can / simdiki_can, Time.deltaTime * 2);
        
        if (simdiki_can < 0)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
       
        if (takip_edilen_kup_no == 1 )
        {
            takip_edilen_kup_no = 1;
        }
        if (takip_edilen_kup_no != 1)
        {
            takip_edilen_kup_no = 101;
        }

        takip_edilen_kup = GameObject.Find(takip_edilen_kup_no.ToString());
        transform.LookAt(takip_edilen_kup.transform);

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * hiz * Time.deltaTime;
        canvas.transform.LookAt(kamera.transform);
      
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "takip_edilen_kup_"+gidecegi_yol.ToString())
        {

        takip_edilen_kup_no++;
        takip_edilen_kup = GameObject.Find(takip_edilen_kup_no.ToString());
        transform.LookAt(takip_edilen_kup.transform);

        }
        
        
        if (other.gameObject.tag == "varis_noktasi")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "kursun")
        {
            Debug.Log("enemy _ kursun");
            can_azalt(other.gameObject.GetComponent<kursun>().damage);
        }

    }

}
