using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nasketpos : MonoBehaviour
{
     float x_cordinate, y_cordinate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
if(ballScript.flag)
{
        x_cordinate = Random.Range(-0.91f, 0.93f);
        y_cordinate = Random.Range(-3.3f, 2.3f);
        Vector3 pos= new Vector3(x_cordinate,y_cordinate,0);
        this.transform.position=pos;
        ballScript.flag=false;

}
       
    }
      
}
