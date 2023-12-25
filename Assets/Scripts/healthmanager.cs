using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthmanager : MonoBehaviour
{
    public static int health = 5;

    public Image[] lives;
    public Sprite fullLife;
    public Sprite emptyLife;
    

    // Update is called once per frame
    void Update()
    {
        foreach(Image img in lives)
        {
           img.sprite = emptyLife;
           
        }
        for(int i = 0; i < health; i++)
        {
            lives[i].sprite = fullLife;
             
        }

       

        
    }
}
