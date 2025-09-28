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
    /// <summary>
    /// Indica la velocidad aplicada den el movimineto lateral
    /// </summary>
    private float velocidadLateral;
    /// <summary>
    ///  Representa la estrategia de movimiento 
    /// </summary>
    private IMovementStrategy strategy;


    #endregion

    #region Ciclo de vida del Script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 250f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 5f;
        SetStrategy(new MovimientoAcelerado());
    }
    private void Update()
    {
        strategy.Move(transform, velocidadLateral);
    }


    // Logica para aplicar fuerzas
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

    #region Logica del Script
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }
    #endregion
}
