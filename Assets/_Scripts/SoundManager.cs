using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource MusicSource;
    public static SoundManager instance;
    // public TextMeshProUGUI text;
    int speed;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PlayMusic(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }
    public void ChangeSpeed(int PlaybackSpeed)
    {
        speed += PlaybackSpeed;
        if (speed >= 1)
        {
            MusicSource.pitch = 2;
            MusicSource.Play();
        }
        Debug.Log(speed);
        
    }
}