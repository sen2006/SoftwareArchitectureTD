using UnityEngine;

public class SimpleEnemyTargetSelector : EnemyTargetSelector
{
    [SerializeField] GameObject target;

    public override GameObject GetTarget()
    {
        return target;
    }
}
