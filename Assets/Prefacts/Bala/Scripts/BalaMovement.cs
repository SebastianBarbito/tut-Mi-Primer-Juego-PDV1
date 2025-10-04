using UnityEngine;

public class BalaMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( 0, 0,4f * Time.deltaTime);
        
    }
}
