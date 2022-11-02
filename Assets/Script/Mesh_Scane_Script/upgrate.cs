using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class upgrate : MonoBehaviour
{
    public Button trt_damage_btn1, trt_damage_btn2, trt_damage_btn3;
    public Button trt_radar_btn1, trt_radar_btn2, trt_radar_btn3;
    public GameObject lock_turret_damage_1,lock_turret_damage_2, lock_turret_damage_3;
    public GameObject lock_turret_radar_1, lock_turret_radar_2, lock_turret_radar_3;


    public Button rocket_damage_btn1, rocket_damage_btn2, rocket_damage_btn3;
    public Button rocket_radar_btn1, rocket_radar_btn2, rocket_radar_btn3;
    public GameObject lock_rocket_damage_1, lock_rocket_damage_2, lock_rocket_damage_3;
    public GameObject lock_rocket_radar_1, lock_rocket_radar_2, lock_rocket_radar_3;





    public Button lazer_damage_btn1, lazer_damage_btn2, lazer_damage_btn3;
    public Button lazer_radar_btn1, lazer_radar_btn2, lazer_radar_btn3;
    public GameObject lock_lazer_damage_1, lock_lazer_damage_2, lock_lazer_damage_3;
    public GameObject lock_lazer_radar_1, lock_lazer_radar_2, lock_lazer_radar_3;

    public TextMeshProUGUI diamondtext;
    public int daimond;

    // Start is called before the first frame update
    void Start()
    {
        Game_Singlaton_Manager game_Singlaton = Game_Singlaton_Manager.Instance;
        daimond = game_Singlaton.diamond;
        diamondtext.text = daimond.ToString();
        // turret damage varsa kilitleri kontrol et
        if (PlayerPrefs.HasKey("trt1_lvl"))
        {
            int trtlvl = PlayerPrefs.GetInt("trt1_lvl");
            if (trtlvl == 1)
            {
                lock_turret_damage_1.SetActive(false);
                trt_damage_btn1.interactable = false;
            }
            if (trtlvl == 2)
            {
                lock_turret_damage_1.SetActive(false);
                lock_turret_damage_2.SetActive(false);
                trt_damage_btn1.GetComponent<Button>().interactable = false;
                trt_damage_btn2.GetComponent<Button>().interactable = false;
            }

            if (trtlvl == 3)
            {
                lock_turret_damage_1.SetActive(false);
                lock_turret_damage_2.SetActive(false);
                lock_turret_damage_3.SetActive(false);
                trt_damage_btn1.GetComponent<Button>().interactable = false;
                trt_damage_btn2.GetComponent<Button>().interactable = false;
                trt_damage_btn3.GetComponent<Button>().interactable = false;
            }
        }
        // turret radar varsa kilitleri kontrol et 

        if (PlayerPrefs.HasKey("trt_radar"))
        {
            int trtradar = PlayerPrefs.GetInt("trt_radar");

            if (trtradar == 1)
            {
                lock_turret_radar_1.SetActive(false);
                trt_radar_btn1.interactable = false;
            }
            if (trtradar == 2)
            {
                lock_turret_radar_1.SetActive(false);
                trt_radar_btn1.interactable = false;
                lock_turret_radar_2.SetActive(false);
                trt_radar_btn2.interactable = false;
            }
            if (trtradar == 3)
            {
                lock_turret_radar_1.SetActive(false);
                trt_radar_btn1.interactable = false;
                lock_turret_radar_2.SetActive(false);
                trt_radar_btn2.interactable = false;
                lock_turret_radar_3.SetActive(false);
                trt_radar_btn3.interactable = false;
            }
        }

        // rocket damage varsa kilitleri kontrol et 
        if (PlayerPrefs.HasKey("rocket_lvl"))
        {
            int rocketdamage = PlayerPrefs.GetInt("rocket_lvl");
            if (rocketdamage == 1)
            {
                rocket_damage_btn1.interactable = false;
                lock_rocket_damage_1.SetActive(false);
            }
            if (rocketdamage == 2)
            {
                rocket_damage_btn1.interactable = false;
                lock_rocket_damage_1.SetActive(false);
                rocket_damage_btn2.interactable = false;
                lock_rocket_damage_2.SetActive(false);
            }
            if (rocketdamage == 3)
            {
                rocket_damage_btn1.interactable = false;
                lock_rocket_damage_1.SetActive(false);
                rocket_damage_btn2.interactable = false;
                lock_rocket_damage_2.SetActive(false);
                rocket_damage_btn3.interactable = false;
                lock_rocket_damage_3.SetActive(false);
            }
        }

        // rocket radar varsa kilitleri kontrol et 
        if (PlayerPrefs.HasKey("rocket_rdr"))
        {
            int radarlevel = PlayerPrefs.GetInt("rocket_rdr");
            if (radarlevel == 1 )
            {
                lock_rocket_radar_1.SetActive(false);
                rocket_radar_btn1.interactable = false;
            }
            if (radarlevel == 2)
            {
                lock_rocket_radar_1.SetActive(false);
                rocket_radar_btn1.interactable = false;
                lock_rocket_radar_2.SetActive(false);
                rocket_radar_btn2.interactable = false;
            }
            if (radarlevel == 3)
            {
                lock_rocket_radar_1.SetActive(false);
                rocket_radar_btn1.interactable = false;
                lock_rocket_radar_2.SetActive(false);
                rocket_radar_btn2.interactable = false;
                lock_rocket_radar_3.SetActive(false);
                rocket_radar_btn3.interactable = false;
            }
        }

        // lazer damage varsa kilitleri kontrol et 
        if (PlayerPrefs.HasKey("lazer_damage"))
        {
            int lazerdamage = PlayerPrefs.GetInt("lazer_damage");
            if (lazerdamage == 1)
            {
                lazer_damage_btn1.interactable = false;
                lock_lazer_damage_1.SetActive(false);
            }
            if (lazerdamage == 2)
            {
                lazer_damage_btn1.interactable = false;
                lock_lazer_damage_1.SetActive(false);
                lazer_damage_btn2.interactable = false;
                lock_lazer_damage_2.SetActive(false);
            }
            if (lazerdamage == 3)
            {
                lazer_damage_btn1.interactable = false;
                lock_lazer_damage_1.SetActive(false);
                lazer_damage_btn2.interactable = false;
                lock_lazer_damage_2.SetActive(false);
                lazer_damage_btn3.interactable = false;
                lock_lazer_damage_3.SetActive(false);
            }
        }

        // lazer radar varsa kilitleri kontrol et 

        if (PlayerPrefs.HasKey("lazer_radar"))
        {
            int lazerradar = PlayerPrefs.GetInt("lazer_radar");
            if (lazerradar == 1 )
            {
                lazer_radar_btn1.interactable = false;
                lock_lazer_radar_1.SetActive(false);
            }
            if (lazerradar == 2)
            {
                lazer_radar_btn1.interactable = false;
                lock_lazer_radar_1.SetActive(false);
                lazer_radar_btn2.interactable = false;
                lock_lazer_radar_2.SetActive(false);
            }
            if (lazerradar == 3)
            {
                lazer_radar_btn1.interactable = false;
                lock_lazer_radar_1.SetActive(false);
                lazer_radar_btn2.interactable = false;
                lock_lazer_radar_2.SetActive(false);
                lazer_radar_btn3.interactable = false;
                lock_lazer_radar_3.SetActive(false);
            }
        }
    }

    public void back()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void Turret1_damage_1_update()
    {
        if (daimond > 10)
        {

        PlayerPrefs.SetInt("trt1_lvl", 1);
        lock_turret_damage_1.SetActive(false);
      
        trt_damage_btn1.GetComponent<Button>().interactable = false;
            daimond = daimond - 10;
            diamondtext.text = daimond.ToString();
        }
    }
    public void Turret1_damage_2_update()
    {
        if (daimond > 15)
        {

        PlayerPrefs.SetInt("trt1_lvl", 2);
        lock_turret_damage_2.SetActive(false);
        trt_damage_btn2.GetComponent<Button>().interactable = false;
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();
        }
    }
    public void Turret1_damage_3_update()
    {
        if (daimond > 20)
        {

        PlayerPrefs.SetInt("trt1_lvl", 3);
        lock_turret_damage_2.SetActive(false);
        trt_damage_btn3.GetComponent<Button>().interactable = false;
            daimond = daimond - 20;
            diamondtext.text = daimond.ToString();
        }
    }

    public void turret_radar_1_update()
    {
        if (daimond > 10)
        {
            daimond = daimond - 10;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("trt_radar", 1);
        lock_turret_radar_1.SetActive(false);
        trt_radar_btn1.interactable = false;
        }
    }
    public void turret_radar_2_update()
    {
        if (daimond > 15)
        {
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();

        PlayerPrefs.SetInt("trt_radar", 2);
        lock_turret_radar_2.SetActive(false);
        trt_radar_btn2.interactable = false;
        }
    }
    public void turret_radar_3_update()
    {
        if (daimond > 20)
        {
            daimond = daimond - 20;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("trt_radar", 3);
        lock_turret_radar_3.SetActive(false);
        trt_radar_btn3.interactable = false;
        }
    }

    public void Rocket_lvl1_update()
    {
        if (daimond >10)
        {
            daimond = daimond - 10;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("rocket_lvl", 1);
        lock_rocket_damage_1.SetActive(false);
        rocket_damage_btn1.GetComponent<Button>().interactable = false;
        }
    }
    public void Rocket_lvl2_update()
    {
        if (daimond > 15)
        {
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("rocket_lvl", 2);
        lock_rocket_damage_2.SetActive(false);
        rocket_damage_btn2.GetComponent<Button>().interactable = false;
        }
    }
    public void Rocket_lvl3_update()
    {
        if (daimond > 20)
        {
            daimond = daimond - 20;
            diamondtext.text = daimond.ToString();

        PlayerPrefs.SetInt("rocket_lvl", 3);
        lock_rocket_damage_3.SetActive(false);
        rocket_damage_btn3.GetComponent<Button>().interactable = false;
        }
    }

    public void rocket_radarlvl1_update()
    {
        if (daimond > 10)
        {
            daimond = daimond - 10;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("rocket_rdr", 1);
        lock_rocket_radar_1.SetActive(false);
        rocket_radar_btn1.interactable = false;
        }
    }
    public void rocket_radarlvl2_update()
    {
        if (daimond > 15)
        {
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("rocket_rdr", 2);
        lock_rocket_radar_2.SetActive(false);
        rocket_radar_btn2.interactable = false;
        }
    }
    public void rocket_radarlvl3_update()
    {
        if (daimond > 20)
        {
            daimond = daimond - 20;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("rocket_rdr", 3);
        lock_rocket_radar_3.SetActive(false);
        rocket_radar_btn3.interactable = false;
        }
    }

    public void lazer_damage_1_update()
    {
        if (daimond > 10)
        {
            daimond = daimond - 10;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("lazer_damage", 1);
        lazer_damage_btn1.interactable = false;
        lock_lazer_damage_1.SetActive(false);
        }
    }

    public void lazer_damage_2_update()
    {
        if (daimond > 15)
        {
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("lazer_damage", 2);
        lazer_damage_btn2.interactable = false;
        lock_lazer_damage_2.SetActive(false);
        }
    }
    public void lazer_damage_3_update()
    {
        if (daimond > 20)
        {
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("lazer_damage", 3);
        lazer_damage_btn3.interactable = false;
        lock_lazer_damage_3.SetActive(false);
        }
    }

    public void lazer_radar_1_update()
    {
        if (daimond > 10)
        {
            daimond = daimond - 10;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("lazer_radar", 1);
        lazer_radar_btn1.interactable = false;
        lock_lazer_radar_1.SetActive(false);
        }
    }
    public void lazer_radar_2_update()
    {
        if (daimond > 15)
        {
            daimond = daimond - 15;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("lazer_radar", 2);
        lazer_radar_btn2.interactable = false;
        lock_lazer_radar_2.SetActive(false);
        }
    }
    public void lazer_radar_3_update()
    {
        if (daimond > 20)
        {
            daimond = daimond - 20;
            diamondtext.text = daimond.ToString();
        PlayerPrefs.SetInt("lazer_radar", 3);
        lazer_radar_btn3.interactable = false;
        lock_lazer_radar_3.SetActive(false);
        }
    }

}
