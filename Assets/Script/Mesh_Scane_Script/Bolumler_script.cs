using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bolumler_script : MonoBehaviour
{
    Game_Singlaton_Manager game_Singlaton;
    public TextMeshProUGUI diamondtext;
    public int daimond;
    public GameObject kilit_level2, kilit_level3, kilit_level4, kilit_level5, kilit_level6, kilit_level7, kilit_level8, kilit_level9, kilit_level10;
    public int level2_open_money, level3_open_money, level4_open_money, level5_open_money, level6_open_money, level7_open_money,
        level8_open_money, level9_open_money, level10_open_money;
    string level2, level3, level4, level5, level6, level7, level8, level9, level10;
    private void Awake()
    {
        Game_Singlaton_Manager game_Singlaton = Game_Singlaton_Manager.Instance;
        

    }
    void Start()
    {
        Game_Singlaton_Manager game_Singlaton = Game_Singlaton_Manager.Instance;
      
        level2 = PlayerPrefs.GetString("level2_aktif"); 
       level3= PlayerPrefs.GetString("level3_aktif"); 
       level4= PlayerPrefs.GetString("level4_aktif"); 
       level5= PlayerPrefs.GetString("level5_aktif"); 
       level6= PlayerPrefs.GetString("level6_aktif"); 
       level7= PlayerPrefs.GetString("level7_aktif"); 
       level8= PlayerPrefs.GetString("level8_aktif"); 
       level9= PlayerPrefs.GetString("level9_aktif");
       level10 = PlayerPrefs.GetString("level10_aktif");
        daimond = game_Singlaton.diamond;
        diamondtext.text = daimond.ToString();
        if (level2 == "evet")
        {
            kilit_level2.SetActive(false);
        }
        if (level3 == "evet")
        {
            kilit_level3.SetActive(false);
        }
        if (level4 == "evet")
        {
            kilit_level4.SetActive(false);
        }
        if (level5 == "evet")
        {
            kilit_level5.SetActive(false);
        }
        if (level6 == "evet")
        {
            kilit_level6.SetActive(false);
        }
        if (level7 == "evet")
        {
            kilit_level7.SetActive(false);
        }
        if (level8 == "evet")
        {
            kilit_level8.SetActive(false);
        }
        if (level9 == "evet")
        {
            kilit_level9.SetActive(false);
        }
        if (level10 == "evet")
        {
            kilit_level10.SetActive(false);
        }
    }


    public void Update()
    {
        
    }
    public void level2_open()
    {
        if (daimond > level2_open_money)
        {
            daimond = daimond - level2_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level2.SetActive(false);
            PlayerPrefs.SetString("level2_aktif","evet");
            diamondtext.text = daimond.ToString();
           
        }
    }
    public void level3_open()
    {
        if (daimond > level3_open_money)
        {
            if (kilit_level2.activeSelf != true)
            {

            daimond = daimond - level3_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level3.SetActive(false);
            PlayerPrefs.SetString("level3_aktif", "evet");
            diamondtext.text = daimond.ToString();
             
            }
        }
    }
    public void level4_open()
    {
        if (daimond > level4_open_money)
        {
            if (kilit_level3.activeSelf != true)
            {

            daimond = daimond - level4_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level4.SetActive(false);
            PlayerPrefs.SetString("level4_aktif", "evet");
            diamondtext.text = daimond.ToString();
               
            }
        }
    }
    public void level5_open()
    {
        if (daimond > level5_open_money)
        {
            if (kilit_level4.activeSelf != true)
            {

            daimond = daimond - level5_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level5.SetActive(false);
            PlayerPrefs.SetString("level5_aktif", "evet");
            diamondtext.text = daimond.ToString();
                
            }
        }
    }
    public void level6_open()
    {
        if (daimond > level6_open_money)
        {
            if (kilit_level5.activeSelf != true)
            {

            daimond = daimond - level6_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level6.SetActive(false);
            PlayerPrefs.SetString("level6_aktif", "evet");
            diamondtext.text = daimond.ToString();
                
            }
        }
    }
    public void level7_open()
    {
        if (daimond > level7_open_money)
        {
            if (kilit_level6.activeSelf != true)
            {

            daimond = daimond - level7_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level7.SetActive(false);
            PlayerPrefs.SetString("level7_aktif", "evet");
            diamondtext.text = daimond.ToString();
                
            }
        }
    }
    public void level8_open()
    {
        if (daimond > level8_open_money)
        {
            if (kilit_level7.activeSelf != true)
            {

            daimond = daimond - level8_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level8.SetActive(false);
            PlayerPrefs.SetString("level8_aktif", "evet");
            diamondtext.text = daimond.ToString();
                
            }
        }
    }
    public void level9_open()
    {
        if (daimond > level9_open_money)
        {
            if (kilit_level8.activeSelf != true)
            {

            daimond = daimond - level9_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level9.SetActive(false);
            PlayerPrefs.SetString("level9_aktif", "evet");
            diamondtext.text = daimond.ToString();
                
            }
        }
    }
    public void level10_open()
    {
        if (daimond > level10_open_money)
        {
            if (kilit_level9.activeSelf != true)
            {

            daimond = daimond - level10_open_money;
            PlayerPrefs.SetInt("diamond", daimond);
            kilit_level10.SetActive(false);
            PlayerPrefs.SetString("level10_aktif", "evet");
            diamondtext.text = daimond.ToString();
               
            }
        }
    }

    public void level1_load()
    {
        SceneManager.LoadScene("Map1_Scane");
    }
    public void level2_load()
    {
        SceneManager.LoadScene("Map2_Scane");
    }
    public void level3_load()
    {
        SceneManager.LoadScene("Map3_Scane");
    }
    public void level4_load()
    {
        SceneManager.LoadScene("Map4_Scane");
    }
    public void level5_load()
    {
        SceneManager.LoadScene("Map5_Scane");
    }
    public void level6_load()
    {
        SceneManager.LoadScene("Map6_Scane");
    }
    public void level7_load()
    {
        SceneManager.LoadScene("Map7_Scane");
    }
    public void level8_load()
    {
        SceneManager.LoadScene("Map8_Scane");
    }
    public void level9_load()
    {
        SceneManager.LoadScene("Map9_Scane");
    }
    public void level10_load()
    {
        SceneManager.LoadScene("");
    }
}
