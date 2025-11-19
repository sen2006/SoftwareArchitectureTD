using UnityEngine;

public abstract class EnemyTargetSelector : MonoBehaviour
{
    public abstract Vector3 GetTarget();
    public abstract void reachedTarget();
}
