using UnityEngine;

/// <summary>
/// Permite el comportamiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// Fuerza utilizada para aplicar el movimiento
    /// </summary>
    private Vector3 fuerzaPorAplicar;

    /// <summary>
    /// Representa el tiempo que ha transcurrido desde la última aplicación de fuerzas
    /// </summary>
    private float tiempoDesdeUltimaFuerza;

    /// <summary>
    /// Indica cada cuánto tiempo debe aplicarse fuerza
    /// </summary>
    private float intervaloTiempo;
    #endregion

    #region Ciclo de vida del Script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 250f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
    }

    void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;

        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }
    #endregion
}
