using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiikkuvaLaatta : MonoBehaviour
{
    private float LaattaNopeus = 1.5f;

    bool moveRight = true;


    void Update()
    {
        if (transform.position.x > 5.80f)
        {
            moveRight = false;
        }

        if (transform.position.x < 2.80f)
        {
            moveRight = true;
        }
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + LaattaNopeus * Time.deltaTime, transform.position.y);      
        }
            
        else
        {
            transform.position = new Vector2(transform.position.x - LaattaNopeus * Time.deltaTime, transform.position.y);           

        }
                
        

       


    }
}
