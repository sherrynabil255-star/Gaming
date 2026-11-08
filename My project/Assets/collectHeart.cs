
using UnityEngine;

public class collectHeart : MonoBehaviour
{
    public AudioClip heartSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerStats.lives++;
            AudioManager.Instance.PlayMusicSFX(heartSound);
            Destroy(gameObject);
        }
    }
}
