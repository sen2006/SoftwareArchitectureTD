using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyTargetSelector))]
[RequireComponent(typeof(Damageable))]
[RequireComponent(typeof(EnemyMovement))]
public class EnemyControler : MonoBehaviour
{
    public static readonly HashSet<GameObject> enemies = new();

    EnemyTargetSelector targetSelector;
    Damageable damageable;
    EnemyMovement movement;

    [SerializeField] int speed = 10;
    [SerializeField] float NodeDistance = .1f;

    // Start is called before the first frame update
    void Start()
    {
        targetSelector = GetComponent<EnemyTargetSelector>();
        damageable = GetComponent<Damageable>();
        movement = GetComponent<EnemyMovement>();

        enemies.Add(this.gameObject);
    }

    private void OnDestroy()
    {
        enemies.Remove(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
        HandleTargeting();
    }

    void CheckHealth()
    {
        if (damageable.GetHealth() <= 0)
        {
            Destroy(gameObject);
        }
    }

    void HandleTargeting()
    {
        Vector3 target = targetSelector.GetTarget();
        float distance = (target - transform.position).magnitude;
        if (distance <= NodeDistance)
        {
            targetSelector.reachedTarget();
            target = targetSelector.GetTarget();
        }
        movement.SetTarget(target);
    }
}
