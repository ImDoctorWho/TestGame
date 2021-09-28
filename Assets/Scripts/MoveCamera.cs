using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _speed;
    void Update()
    {
        if (_player != null)
        {
            Vector3 _target = new Vector3(_player.transform.position.x, _player.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, _target, _speed * Time.deltaTime);
        }
    }
}
