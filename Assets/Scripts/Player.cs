using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _button;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Time.timeScale = 0f;
            _button.SetActive(true);
        }
    }

    public void PlayerDeath()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
