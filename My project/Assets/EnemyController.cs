

using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxSpeed;
    public int damage;
    public SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // If true turn to false, if false turn to true
    public void Flip()
    {
        sr.flipX = !sr.flipX;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
        else if (other.tag == "Wall")
        {
            Flip();
        }
    }
}