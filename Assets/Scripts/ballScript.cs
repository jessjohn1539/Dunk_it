using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ballScript : MonoBehaviour
{
    private float ballScorePosition;
    public UnityEvent scoredEvent;
    public static bool flag=false;
      // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider){
        ballScorePosition = transform.position.y;
        
    
    }
    void OnTriggerExit2D(Collider2D collider){
        if(transform.position.y < ballScorePosition){
            flag=true;
            // Debug.Log("Scored");
            scoredEvent.Invoke();
            timedelay();
        }
       
    
    }

    IEnumerator timedelay()
    {


yield return new WaitForSeconds(1);
flag=false;

    }
}
