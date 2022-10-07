using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game_Singlaton_Manager :MonoBehaviour

{

    private static Game_Singlaton_Manager _instance;

    public static Game_Singlaton_Manager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Game_Singlaton_Manager>();
                if (_instance == null)
                {

                _instance = new GameObject("Managerr").AddComponent<Game_Singlaton_Manager>();
                }
            }
            return _instance;
        }
    }
    public int diamond;
    
    private void Awake()
    {
        if (_instance != null) Destroy(this);
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        if (PlayerPrefs.HasKey("diamond"))
        {         
            diamond = PlayerPrefs.GetInt("diamond");
        }
        else
        {
            diamond = 10;
        }
        
    }

    

    void Update()
    {
        
    }
}
