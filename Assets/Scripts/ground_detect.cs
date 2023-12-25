using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ground_detect : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "ball"){
        healthmanager.health-=1;
        }

    if(healthmanager.health == 0){

        SceneManager.LoadScene(2);
        healthmanager.health=5;
    }
    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(healthmanager.health);
    }
}
