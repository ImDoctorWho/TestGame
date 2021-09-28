using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Toggle _onOffMusic;

    public void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        int saveMusic = PlayerPrefs.GetInt("MUSIC_On_OFF", 0);
        if(saveMusic == 0)
        {
            _onOffMusic.isOn = false;
            _audioSource.playOnAwake = false;
        }
        if(saveMusic == 1)
        {
            _onOffMusic.isOn = true;
            _audioSource.playOnAwake = true;
        }
    }

    public void DisableMusic()
    {
        _audioSource.playOnAwake = false;
        PlayerPrefs.SetInt("MUSIC_On_OFF", 0);
    }
    public void EnableMusic()
    {
        _audioSource.playOnAwake = true;
        PlayerPrefs.SetInt("MUSIC_On_OFF", 1);
    }
}
