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
        //Loads the scene named "Exit"
        UnityEngine.SceneManagement.SceneManager.LoadScene("Exit");
    }
}
