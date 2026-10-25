
using UnityEngine;

public class GhostEnemy : EnemyController
{
    // Because ghosts can pass through walls, the Trigger function is overridden from the Superclass
    // to remove the Flip function upon hitting a wall
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
    }
}
