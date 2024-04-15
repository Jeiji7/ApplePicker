using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DeadPlayer : MonoBehaviour
{
    public GameObject Lvl1;
    public GameObject Lvl2;
    public GameObject Lvl3;
    public GameObject deadScreen;
    public GameObject ScoreeScreen;
    public GameObject dashSlider;
    public static int health;
    [Header("MusicDead")]
    public AudioClip musicGame;
    private AudioSource musicSource;
    public Music musics;
    private void Start()
    {
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicGame;
        health = 1; 

    }
    void Update()
    {
        if (StatesPlayer.countLive == 3)
        {
            Lvl1.SetActive(false);
        }
        else if (StatesPlayer.countLive == 2)
        {
            Lvl2.SetActive(false);
        }
        else if(StatesPlayer.countLive == 1)
        {
            Lvl3.SetActive(false);
            float currentScore = StatesPlayer.scorePlayer;
            PlayerPrefs.SetFloat("CurrentScore", currentScore);
            Debug.Log("You Deaddd");
            ScoreeScreen.SetActive(false);
            dashSlider.SetActive(false);
            deadScreen.SetActive(true);
            health = 0;
            StatesPlayer.countLive = 4;
            Time.timeScale = 0;
            musics.musicSource.Stop();
            musicSource.Play();
        }
        
    }
}
