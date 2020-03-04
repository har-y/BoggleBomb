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
        StartCoroutine("BombSpawnerRoutine");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BombSpawnerRoutine()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1.25f));
        BombsSpawner();
        StartCoroutine("BombSpawnerRoutine");
    }

    private void BombsSpawner()
    {
        GameObject _copyBomb = Instantiate(_bombPrefab, new Vector2(Random.Range(-_positionValue, _positionValue), transform.position.y), Quaternion.identity);
        _copyBomb.transform.parent = _bombPrefabContainer.transform;
    }
}