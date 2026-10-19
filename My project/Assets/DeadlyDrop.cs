using UnityEngine;

public class DeadlyDrop : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
   { 
        if (other.CompareTag("Player"))
        {
            LevelManager levelManager = FindObjectOfType<LevelManager>();

            if (levelManager.currentCheckpoint != null)
            {
                other.transform.position =
                    levelManager.currentCheckpoint.transform.position;
            }
        }
    }
}