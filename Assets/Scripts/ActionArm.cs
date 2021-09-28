using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionArm : MonoBehaviour
{
    [Header("Кнопка действия")]
    [SerializeField] private GameObject _activeButton;
    [Header("Что должно исчезнуть")]
    [SerializeField] private GameObject _targetActive;

    [Header("Дополнительная логика")]
    [SerializeField] private bool _isActivated;

    public void isActivatedArm()
    {
        _isActivated = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(!_isActivated) _activeButton.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        _activeButton.SetActive(false);
    }
}
