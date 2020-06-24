using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEnemy : MonoBehaviour
{
    //position
   private Vector2 _startPos;
   private Vector2 _endPos;

    //push
    private const float _step = 0.15f;
    private int _i;
    private const float _distPush = 3;
    private bool _enemyPush;

    public Transform transformEnemy;
    private void Start()
    {
        transformEnemy.position =transform.position;
        _i = 0;
        _enemyPush = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("weapon"))
        {
            takeInfoForPush();
        }
    }
    private void FixedUpdate()
    {
        pushEnemy();
    }

    private void takeInfoForPush()
    {
        _enemyPush = true;
        _i = 0;
        _startPos = transformEnemy.position;
        _endPos.y = _startPos.y;
        _endPos.x = _startPos.x + _distPush;
    }

    private void pushEnemy()
    {

        if (_enemyPush == true && _i < 20)
        {
            transformEnemy.position += transformEnemy.right * _step;
            _i++;
        }
        else _enemyPush= false;
    }
}
