using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InizializedGame : MonoBehaviour
{
    [SerializeField] private GameObject _loseCan;
    [SerializeField] private GameObject _winCan;
    [SerializeField] private Text _coins;

    void Awake()
    {
        _loseCan.SetActive(false);
        _winCan.SetActive(false);
        _coins.text = "0";
    }

}
