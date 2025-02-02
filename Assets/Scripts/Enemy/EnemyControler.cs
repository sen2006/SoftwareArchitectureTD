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
        movement.SetTarget(targetSelector.GetTarget().transform.position);
    }

    void CheckHealth()
    {
        if (damageable.GetHealth() <= 0)
        {
            Destroy(gameObject);
        }
    }
}
