using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            IncreaseScore();
            Destroy(collision.gameObject);
        }
    }

    private void IncreaseScore()
    {
        _score++;
        _text.text = "Score: " + _score;
    }
}
