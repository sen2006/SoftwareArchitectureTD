using UnityEngine;

public abstract class TowerTargetSelector : MonoBehaviour
{
    public abstract GameObject GetTarget(int maxRange);
}
