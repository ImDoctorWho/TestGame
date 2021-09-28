using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private enum RotateState
    {
        Left,
        Right
    }
    [Header("Передвижение")]
    [SerializeField] private float _speedMove;
    [SerializeField] private float _rotateMove;
    [SerializeField] private bool _isMoving = false;
    [SerializeField] private Vector2 _forceJump;
    [SerializeField] private Rigidbody2D _rigid;
    [SerializeField] private RotateState _rotState = RotateState.Left;
    [SerializeField] private bool _isGround = false;
    

    [Header("Объекты и префабы")]
    [SerializeField] private GameObject _checkGround;
    [SerializeField] private GameObject _player;

    [Header("UI")]
    [SerializeField] private GameObject _loseCanvas;

    public void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (_isMoving)
        {
            _player.transform.position = new Vector2(_player.transform.position.x + _rotateMove * Time.deltaTime,
                                                     _player.transform.position.y);
        }
    }

    public void MoveLeft()
    {
        SetRotation(RotateState.Left);
        _rotateMove = -_speedMove;
        _isMoving = true;
    }

    public void MoveRight()
    {
        SetRotation(RotateState.Right);
        _isMoving = true;
        _rotateMove = _speedMove;
    }
    
    public void StopMoving()
    {
        _isMoving = false;
    }

    public void Jump()
    {
        if (_isGround)
        {
            _rigid.AddForce(_forceJump, ForceMode2D.Impulse);
            _isGround = false;
        }
    }
    
    private void SetRotation(RotateState rotState)
    {
        _rotState = rotState;
        if (_rotState == RotateState.Left) _player.transform.rotation = Quaternion.Euler(0,0,0);
        if (_rotState == RotateState.Right) _player.transform.rotation = Quaternion.Euler(0,180,0);
    }

    public void PlayerDied()
    {
        Destroy(this.gameObject);
        _loseCanvas.SetActive(true);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            _isGround = true;
        }
        if (collision.collider.tag == "Trap")
        {
            PlayerDied();
        }
    }
}
