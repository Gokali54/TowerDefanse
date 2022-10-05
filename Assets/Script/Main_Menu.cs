using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("Bolumler");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
