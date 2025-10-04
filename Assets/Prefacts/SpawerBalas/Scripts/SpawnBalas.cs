using UnityEngine;

public class SpawnBalas : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("DispararBala", 3f, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DispararBala()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
