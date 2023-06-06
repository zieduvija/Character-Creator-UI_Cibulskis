using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScenes : MonoBehaviour {

    public void Create()
    {
        //Loads the scene named "Creator"
        UnityEngine.SceneManagement.SceneManager.LoadScene("Creator");
    }

    public void Info()
    {
        //Loads the scene named "Info"
        UnityEngine.SceneManagement.SceneManager.LoadScene("Info");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
    
    public void Clothing()
    {
        //Loads the scene named "Clothing"
        UnityEngine.SceneManagement.SceneManager.LoadScene("Clothing");
    }
    
    public void Starts()
    {
        //Loads the scene named "Start"
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start-screen");
    }
    
    
}
