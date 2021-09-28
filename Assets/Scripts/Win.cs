using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject _winCanvas;
    [SerializeField] private Text _coins;
    [SerializeField] private Text _coinsFinishTab;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        _winCanvas.SetActive(true);
        _coinsFinishTab.text = _coins.text;
        PlayerPrefs.SetInt("SCORE_IN_LEVEL", int.Parse(_coins.text));
        Time.timeScale = 0;
    }
}
