using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _enemyContainer;
    [SerializeField] private bool _stopSpawning = false;
    [SerializeField] private float _spawnRate = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
        OnPlayerDeath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnRoutine()
    {
        while (_stopSpawning == false)
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-8.0f, 8.0f), 7, 0);
            GameObject newEnemy = Instantiate(_enemyPrefab, posToSpawn, Quaternion.identity);
            newEnemy.transform.parent = _enemyContainer.transform;
            yield return new WaitForSeconds(_spawnRate);
        }
    }
    public void OnPlayerDeath()
    {
        _stopSpawning = true;
    }
}