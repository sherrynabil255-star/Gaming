using UnityEngine;
public class LevelManager : MonoBehaviour
{
    
public GameObject currentCheckpoint;
 // so we can update the current checkpoint from within Unity

    // Use this for initialization
    void Start()
    {
        
      currentCheckpoint = null;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void RespawnPlayer()
    {
        FindObjectOfType<PlayerController>().transform.position = currentCheckpoint.transform.position;
        //Search for the asset/object called PlayerController (your player's script) to locate the player.
        //Once you've found it, change its player game object's position to be at the last checkpoint the player passed through before he/she died
    }
}
