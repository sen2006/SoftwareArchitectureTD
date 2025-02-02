using UnityEngine;

public class ClosestTowerTargetSelector : TowerTargetSelector
{
    public override GameObject GetTarget(int maxRange)
    {
        float closestDistance = maxRange;
        GameObject closest = null;
        foreach(GameObject enemy in EnemyControler.enemies)
        {
            if ((enemy.transform.position - transform.position).magnitude < closestDistance)
            {
                closest = enemy;
                closestDistance = (enemy.transform.position - transform.position).magnitude;
            }
        }
        return closest;
    }
}
