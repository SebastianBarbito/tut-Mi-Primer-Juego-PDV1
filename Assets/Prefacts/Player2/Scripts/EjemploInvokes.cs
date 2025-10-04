using UnityEngine;

public class EjemploInvokes : MonoBehaviour
{
    void Start()
    {
        Invoke("MostrarMensajeUnico", 5f);
        InvokeRepeating("MostrarMensajesContinuos", 3f, 2f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MostrarMensajeUnico()
    {
        Debug.Log("Ejecutado luego de 5 segundos");
    }

    public void MostrarMensajesContinuos()
    { 
        Debug.Log("Ejecutado luego de 3 segundos y repitiendose cada 2 segundo");
    }
}
