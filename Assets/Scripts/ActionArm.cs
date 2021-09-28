using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionArm : MonoBehaviour
{
    [Header("������ ��������")]
    [SerializeField] private GameObject _activeButton;
    [Header("��� ������ ���������")]
    [SerializeField] private GameObject _targetActive;

    [Header("�������������� ������")]
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
