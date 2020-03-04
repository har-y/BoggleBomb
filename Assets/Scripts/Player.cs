using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 10f;
    private float _positionValue = 2.65f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector2 currentPosition = transform.position;
        float _horizontal = Input.GetAxis("Horizontal");

        if (_horizontal > 0)
        {
            currentPosition.x += _speed * Time.deltaTime;
        }
        else if (_horizontal < 0)
        {
            currentPosition.x -= _speed * Time.deltaTime;
        }

        if (currentPosition.x < -_positionValue)
        {
            currentPosition.x = -_positionValue;
        }

        if (currentPosition.x > _positionValue)
        {
            currentPosition.x = _positionValue;
        }

        transform.position = currentPosition;
    }
}
