using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBehaviour : MonoBehaviour
{
    public int speed = 2;

    private void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        
        if (transform.position.y > 6.9)
        {
            
            transform.position = new Vector3(transform.position.x, -4.84f , transform.position.z);
        }
       
        
    }
}