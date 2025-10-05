using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
            if (collision.collider.name == "Player")
            {
            Destroy(gameObject);
            }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
