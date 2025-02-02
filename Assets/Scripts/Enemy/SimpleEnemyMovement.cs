using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class SimpleEnemyMovement : EnemyMovement
{
    [SerializeField] float speed = 1;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (target != null)
        {
            Debug.DrawLine(transform.position, target, Color.cyan);

            Vector3 velocity = target - transform.position;
            velocity.y = 0;
            velocity.Normalize();
            velocity *= speed;

            rb.velocity = velocity;
        }
    }
}
