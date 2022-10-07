using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("Bolumler");
    }

   public void deleteee()
    {
        PlayerPrefs.DeleteAll();
    }
    public void settings()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
