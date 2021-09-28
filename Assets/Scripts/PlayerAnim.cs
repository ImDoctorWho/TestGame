using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [SerializeField] private Animator _playerAnim;

    public void Start()
    {
        _playerAnim = GetComponent<Animator>();
    }

    public void PlayerWalk()
    {
        _playerAnim.SetBool("IsWalk", true);
    }

    public void PlayerStop()
    {
        _playerAnim.SetBool("IsWalk", false);
    }

    public void PlayerJump()
    {
        _playerAnim.SetBool("IsJump", true);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            _playerAnim.SetBool("IsJump", false);
        }
    }
}
