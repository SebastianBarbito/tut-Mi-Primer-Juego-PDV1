using UnityEngine;

public interface IMovementStrategy
{
    void Move(Transform transform, float speed, float dirrection);
}
