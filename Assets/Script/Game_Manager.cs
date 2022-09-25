using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public Transform dogma_noktasi; 
    public GameObject Enemy_1, Enemy_2, Enemy_3, Enemy_4, Enemy_5, Enemy_6, Enemy_7, Enemy_8, Enemy_9;
    public int Enemy_1_path, Enemy_2_path, Enemy_3_path, Enemy_4_path, Enemy_5_path,
        Enemy_6_path, Enemy_7_path, Enemy_8_path, Enemy_9_path;
    public int Enemy_1_dogum_sayisi, Enemy_2_dogum_sayisi, Enemy_3_dogum_sayisi, Enemy_4_dogum_sayisi, Enemy_5_dogum_sayisi
        , Enemy_6_dogum_sayisi, Enemy_7_dogum_sayisi, Enemy_8_dogum_sayisi, Enemy_9_dogum_sayisi;
    public int Enemy_1_dogum_sure, Enemy_2_dogum_sure, Enemy_3_dogum_sure, Enemy_4_dogum_sure, Enemy_5_dogum_sure
       , Enemy_6_dogum_sure, Enemy_7_dogum_sure, Enemy_8_dogum_sure, Enemy_9_dogum_sure;

    public int Enemy_1_yol, Enemy_2_yol, Enemy_3_yol, Enemy_4_yol, Enemy_5_yol, Enemy_6_yol, Enemy_7_yol, Enemy_8_yol, Enemy_9_yol;

    int Enemy_1_ds, Enemy_2_ds, Enemy_3_ds, Enemy_4_ds, Enemy_5_ds, Enemy_6_ds, Enemy_7_ds, Enemy_8_ds, Enemy_9_ds;

    // Start is called before the first frame update
    void Start()
    {
        // void adý , ilk komut bekleme süresi , sýklýk
        InvokeRepeating("Enemy_1_invoke", 2, Enemy_1_dogum_sure);
        InvokeRepeating("Enemy_2_invoke", 2, Enemy_2_dogum_sure);
    }
    // Update is called once per frame
    void Update()
    {
        if (Enemy_1_ds >= Enemy_1_dogum_sayisi)
        {
            CancelInvoke("Enemy_1_invoke");
        }
        if (Enemy_2_ds >= Enemy_2_dogum_sayisi)
        {
            CancelInvoke("Enemy_2_invoke");
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
}
