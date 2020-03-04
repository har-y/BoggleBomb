using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _bombPrefab;
    [SerializeField] private GameObject _bombPrefabContainer;

    private float _positionValue = 2.65f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("BombsSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BombSpawnerRoutine()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        BombsSpawner();
    }

    private void BombsSpawner()
    {
        GameObject tmp = Instantiate(_bombPrefab, new Vector2(Random.Range(-_positionValue, _positionValue), transform.position.y), Quaternion.identity);
        tmp.transform.parent = _bombPrefabContainer.transform;

        if (tmp.transform.position.y <= -6f)
        {
            Destroy(tmp.gameObject);
        }

        StartCoroutine("BombsSpawner");
    }
}
