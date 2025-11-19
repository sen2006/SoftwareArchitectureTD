using UnityEngine;

public class SimpleEnemyTargetSelector: EnemyTargetSelector
{
    [SerializeField] Transform target;

    public override Vector3 GetTarget()
    {
        return target.position;
    }

    public override void reachedTarget() { }
}
