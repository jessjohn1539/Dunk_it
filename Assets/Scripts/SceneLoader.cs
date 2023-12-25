using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene(){
        SceneManager.LoadScene(1);
       
    }
    public void LoadHomeScene(){
        SceneManager.LoadScene(0); 
    }
    public void LoadCreditScene(){
        SceneManager.LoadScene(3); 
    }
}
