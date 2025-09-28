using UnityEngine;

public class MovimientoLateral : IMovementStrategy
{
    public void Move(Transform transform, float speed)
    {
        float dirrection = Input.GetAxis("Horizontal");
        transform.Translate(dirrection * speed * Time.deltaTime, 0, 0);
    }
}
