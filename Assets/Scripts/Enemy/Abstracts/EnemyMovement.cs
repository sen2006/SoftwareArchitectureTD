using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    protected Vector3 target;
    public void SetTarget(Vector3 position)
    {
        target = position;
    }
}
