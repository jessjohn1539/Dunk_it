using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    private float startposX;
    private float startposY;
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld==true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startposX, mousePos.y - startposY, 0);
        }
    }
    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        startposX = mousePos.x - this.transform.localPosition.x;
        startposY = mousePos.y - this.transform.localPosition.y;

        isBeingHeld = true;
        }
    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
