using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public Transform dogma_noktasi;

    public int bolum_baslangic_parasi;
    public int bolum_gececek_max_dusman;

    public GameObject silah_olustur_cavas, silah_manager_canvas;

    public GameObject Enemy_1, Enemy_2, Enemy_3, Enemy_4, Enemy_5, Enemy_6, Enemy_7, Enemy_8, Enemy_9;

    public int Enemy_1_dogum_sayisi, Enemy_2_dogum_sayisi, Enemy_3_dogum_sayisi, Enemy_4_dogum_sayisi, Enemy_5_dogum_sayisi
        , Enemy_6_dogum_sayisi, Enemy_7_dogum_sayisi, Enemy_8_dogum_sayisi, Enemy_9_dogum_sayisi;
    public int Enemy_1_dogum_sure, Enemy_2_dogum_sure, Enemy_3_dogum_sure, Enemy_4_dogum_sure, Enemy_5_dogum_sure
       , Enemy_6_dogum_sure, Enemy_7_dogum_sure, Enemy_8_dogum_sure, Enemy_9_dogum_sure;

    public int Enemy_1_yol, Enemy_2_yol, Enemy_3_yol, Enemy_4_yol, Enemy_5_yol, Enemy_6_yol, Enemy_7_yol, Enemy_8_yol, Enemy_9_yol;

    int Enemy_1_ds, Enemy_2_ds, Enemy_3_ds, Enemy_4_ds, Enemy_5_ds, Enemy_6_ds, Enemy_7_ds, Enemy_8_ds, Enemy_9_ds;


   public int suanki_para;
   public int gecen_dusman;
   


    public void para_artir(int gelen_para)
    {
        suanki_para = suanki_para + gelen_para;
    }
    public void para_azalt(int gelen_para)
    {
        suanki_para = suanki_para - gelen_para;
    }
    public void gecen_dusman_artir()
    {
        gecen_dusman++;
    }


    // Start is called before the first frame update
    void Start()
    {
        suanki_para = bolum_baslangic_parasi;
        // void adý , ilk komut bekleme süresi , sýklýk
        InvokeRepeating("Enemy_1_invoke", 2, Enemy_1_dogum_sure);
        InvokeRepeating("Enemy_2_invoke", 2, Enemy_2_dogum_sure);
        InvokeRepeating("Enemy_3_invoke", 2, Enemy_3_dogum_sure);
        InvokeRepeating("Enemy_4_invoke", 2, Enemy_4_dogum_sure);
        InvokeRepeating("Enemy_5_invoke", 2, Enemy_5_dogum_sure);
        InvokeRepeating("Enemy_6_invoke", 2, Enemy_6_dogum_sure);
        InvokeRepeating("Enemy_7_invoke", 2, Enemy_7_dogum_sure);
        InvokeRepeating("Enemy_8_invoke", 2, Enemy_8_dogum_sure);
        InvokeRepeating("Enemy_9_invoke", 2, Enemy_9_dogum_sure);
    }
    // Update is called once per frame
    void Update()
    {      

        if (gecen_dusman > bolum_gececek_max_dusman)
        {
            Debug.LogError("bitti");
        }

        if (Enemy_1_ds >= Enemy_1_dogum_sayisi)
        {
            CancelInvoke("Enemy_1_invoke");
        }
        if (Enemy_2_ds >= Enemy_2_dogum_sayisi)
        {
            CancelInvoke("Enemy_2_invoke");
        }
        if (Enemy_3_ds >= Enemy_3_dogum_sayisi)
        {
            CancelInvoke("Enemy_3_invoke");
        }
        if (Enemy_4_ds >= Enemy_4_dogum_sayisi)
        {
            CancelInvoke("Enemy_4_invoke");
        }
        if (Enemy_5_ds >= Enemy_5_dogum_sayisi)
        {
            CancelInvoke("Enemy_5_invoke");
        }
        if (Enemy_6_ds >= Enemy_6_dogum_sayisi)
        {
            CancelInvoke("Enemy_6_invoke");
        }
        if (Enemy_7_ds >= Enemy_7_dogum_sayisi)
        {
            CancelInvoke("Enemy_7_invoke");
        }
        if (Enemy_8_ds >= Enemy_8_dogum_sayisi)
        {
            CancelInvoke("Enemy_8_invoke");
        }
        if (Enemy_9_ds >= Enemy_9_dogum_sayisi)
        {
            CancelInvoke("Enemy_9_invoke");
        }
    }

    public void Enemy_1_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_1, dogma_noktasi.position, Quaternion.identity);
        Enemy_1_ds++;
    }

    public void Enemy_2_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_2, dogma_noktasi.position, Quaternion.identity);
        Enemy_2_ds++;
    }

    public void Enemy_3_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_3, dogma_noktasi.position, Quaternion.identity);
        Enemy_3_ds++;
    }
    public void Enemy_4_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_4, dogma_noktasi.position, Quaternion.identity);
        Enemy_4_ds++;
    }
    public void Enemy_5_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_5, dogma_noktasi.position, Quaternion.identity);
        Enemy_5_ds++;
    }
    public void Enemy_6_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_6, dogma_noktasi.position, Quaternion.identity);
        Enemy_6_ds++;
    }
    public void Enemy_7_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_7, dogma_noktasi.position, Quaternion.identity);
        Enemy_7_ds++;
    }
    public void Enemy_8_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_8, dogma_noktasi.position, Quaternion.identity);
        Enemy_8_ds++;
    }
    public void Enemy_9_invoke()
    {
        GameObject new_enemy = Instantiate(Enemy_9, dogma_noktasi.position, Quaternion.identity);
        Enemy_9_ds++;
    }


}
