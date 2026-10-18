using UnityEngine;

public class BrickBreak : MonoBehaviour
{
    public Sprite explodedBlock;
    private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        if (collision.gameObject.CompareTag("Player"))
{
    if (collision.transform.position.y < transform.position.y)
    {
        GetComponent<SpriteRenderer>().sprite = explodedBlock;
        Destroy(gameObject, 0.5f);
    }
}
    }
}
}