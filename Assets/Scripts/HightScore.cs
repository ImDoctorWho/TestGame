using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    [SerializeField] private Text _score;

    public void Awake()
    {
        _score.text = PlayerPrefs.GetInt("SCORE_IN_LEVEL").ToString();
    }
}
