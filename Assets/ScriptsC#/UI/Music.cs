using UnityEngine.UI;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject musicBad;
    public AudioClip musicGame;
    public AudioSource musicSource;
    private bool isMusicPlaying;

    private void Start()
    {
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicGame;
        musicSource.loop = true;
        isMusicPlaying = false;
        ToggleMusic();
    }
    public void ToggleMusic()
    {
        if (isMusicPlaying)
        {
            musicSource.Pause();
            isMusicPlaying = false;
            musicBad.SetActive(true);
        }
        else
        {
            if (musicSource.time == musicSource.clip.length) 
            {
                musicSource.time = 0;
            }
            musicSource.Play();
            isMusicPlaying = true;
            musicBad.SetActive(false);
        }
    }
}
