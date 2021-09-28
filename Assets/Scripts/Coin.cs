using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coin : MonoBehaviour
{
    [SerializeField] private Text _countCoin;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        int i = int.Parse(_countCoin.text) + 1;

        _countCoin.text = i.ToString();
        Destroy(this.gameObject);
    }
}
