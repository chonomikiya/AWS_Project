using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    SceneManager sceneManager = new SceneManager();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeSceneMenu(){
        if(SceneManager.GetActiveScene().name == "title"){
            SceneManager.LoadScene("menu");
        }
    }
    public void Button_Quit(){
        if(SceneManager.GetActiveScene().name == "title"){
            Application.Quit();
        } 
    }
}
