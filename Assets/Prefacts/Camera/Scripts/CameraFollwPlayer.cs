using UnityEngine;

public class CameraFollwPlayer : MonoBehaviour
{

    private Vector3 offset;
    private PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = new Vector3(0, 1, -5);
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    void LateUpdate()
    {
       gameObject.transform.position = playerMovement.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
