
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Static instance
    public static AudioManager instance;

    // Audio Sources
    public AudioSource musicSource;
    public AudioSource sfxSource;

    // Background music clips
    public AudioClip overworldMusic;
    public AudioClip caveMusic;

    // Array of sound effects
    public AudioClip[] variousSFX;

    void Awake()
    {
        // Make sure there is only one Audio Manager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Play overworld background music
        musicSource.clip = overworldMusic;
        musicSource.Play();
    }

    // Play a sound effect
    public void PlayMusicSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    // Play a music clip
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    // Play a random sound effect
    public void PlayRandomSFX(params AudioClip[] clips)
    {
        variousSFX = clips;

        int index = Random.Range(0, variousSFX.Length);

        sfxSource.PlayOneShot(variousSFX[index]);
    }
}
