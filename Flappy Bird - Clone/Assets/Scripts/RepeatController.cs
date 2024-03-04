using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatController : MonoBehaviour
{
    private int speed = 2;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if (transform.position.x < -4)
        {
            
            transform.position = new Vector3(5,transform.position.y , transform.position.z);
        }
       
        
    }
}
