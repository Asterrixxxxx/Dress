using UnityEngine;

public class Audio : MonoBehaviour
{


    public static Audio Instance {get; private set;}

    [Header("Audio Sources")]
    public AudioSource musicSources;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }
    }
       
    private void Start()
    {
        if(backgroundMusic != null && musicSources != null)
        {
            musicSources.clip = backgroundMusic;
            musicSources.loop = true;
            musicSources.Play();
        }
    }

    public void PlayMusic(AudioClip clip)
    {
        if(clip != null && musicSources != null)
        {
            musicSources.clip = clip;
            musicSources.loop = true;
            musicSources.Play();
        }
    }

     public void Mutebutton(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
