using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public AudioSource bgMusicSource;
    public AudioSource clickSoundSource;

    // Make sure only one instance of AudioManager exists
    private void Awake()
    {
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

    private void Start()
    {
        // Get or add the AudioSource components
        bgMusicSource = GetComponent<AudioSource>();
        if (bgMusicSource == null)
        {
            bgMusicSource = gameObject.AddComponent<AudioSource>();
        }

        clickSoundSource = gameObject.AddComponent<AudioSource>();
    }

    private void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            PlayMouseClickSound();
        }
    }

    private void PlayMouseClickSound()
    {
        // Play your mouse click sound here
        // Example: clickSoundSource.PlayOneShot(yourClickSoundClip);
    }

    public void PlayBackgroundMusic(AudioClip musicClip)
    {
        bgMusicSource.clip = musicClip;
        bgMusicSource.loop = true;
        bgMusicSource.Play();
    }
}