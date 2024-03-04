using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class PlantMover : MonoBehaviour
{
    private int speed = 2;

    private void Update()
    {
       var position = new Vector3(0, Random.Range(-5f,-1f), 0);
        
        if (transform.position.x < -5)
        {
            
            transform.position = new Vector3(3,position.y , 0);
        }
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
